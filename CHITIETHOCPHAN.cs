using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTCSDL1
{
    public partial class CHITIETHOCPHAN : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-TA85D1G\SQLEXPRESS;Initial Catalog=QLPhongMay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void hienthi()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MALHP N'Mã lớp',MAGV N'Mã giáo viên',MASV N'Mã sinh viên', TENLHP N'Tên lớp', HOTENGV N'Tên giáo viên', HOTENSV N'Tên sinh viên' from CT_HOCPHAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_CT.DataSource = table;
        }
        public CHITIETHOCPHAN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHITIETHOCPHAN_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO CT_HOCPHAN(MALHP,MAGV,MASV,TENLHP,HOTENGV,HOTENSV) VALUES (@MALHP,@MAGV,@MASV,@TENLHP,@HOTENGV,@HOTENSV)";
            command = new SqlCommand(sqlINSERT, connection);
            command.Parameters.AddWithValue("MALHP", txtmalop.Text);
            command.Parameters.AddWithValue("MAGV", txtmagv.Text);
            command.Parameters.AddWithValue("MASV", txtmsv.Text);
            command.Parameters.AddWithValue("TENLHP", txttenlop.Text);
            command.Parameters.AddWithValue("HOTENGV", txttengv.Text);
            command.Parameters.AddWithValue("HOTENSV", txttensv.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE CT_HOCPHAN SET MALHP=@MALHP,MAGV=@MAGV,MASV=@MASV,TENLHP=@TENLHP,HOTENGV=@HOTENGV,HOTENSV=@HOTENSV WHERE MALHP=@MALHP";
            command = new SqlCommand(sqlEDIT, connection);
            command.Parameters.AddWithValue("MALHP", txtmalop.Text);
            command.Parameters.AddWithValue("MAGV", txtmagv.Text);
            command.Parameters.AddWithValue("MASV", txtmsv.Text);
            command.Parameters.AddWithValue("TENLHP", txttenlop.Text);
            command.Parameters.AddWithValue("HOTENGV", txttengv.Text);
            command.Parameters.AddWithValue("HOTENSV", txttensv.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM CT_HOCPHAN WHERE MALHP=@MALHP";
            command = new SqlCommand(sqlDELETE, connection);
            command.Parameters.AddWithValue("MALHP", txtmalop.Text);
            command.Parameters.AddWithValue("MAGV", txtmagv.Text);
            command.Parameters.AddWithValue("MASV", txtmsv.Text);
            command.Parameters.AddWithValue("TENLHP", txttenlop.Text);
            command.Parameters.AddWithValue("HOTENGV", txttengv.Text);
            command.Parameters.AddWithValue("HOTENSV", txttensv.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlSEARCH = "select MALHP N'Mã lớp',MAGV N'Mã giáo viên',MASV N'Mã sinh viên', TENLHP N'Tên lớp', HOTENGV N'Tên giáo viên', HOTENSV N'Tên sinh viên' from CT_HOCPHAN WHERE MALHP=@MALHP";
            command = new SqlCommand(sqlSEARCH, connection);

            command.Parameters.AddWithValue("MALHP", txttimkiem.Text);


            command.ExecuteNonQuery();

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_CT.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}
