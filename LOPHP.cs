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
    public partial class LOPHP : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-TA85D1G\SQLEXPRESS;Initial Catalog=QLPhongMay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void hienthi()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MALHP N'Mã lớp',TENLHP N'Tên lớp',TENHP N'Tên học phần' FROM LOPHOCPHAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_LHP.DataSource = table;
        }
        public LOPHP()
        {
            InitializeComponent();
        }

     

        private void LOPHP_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO LOPHOCPHAN(MALHP,TENLHP,TENHP) VALUES (@MALHP,@TENLHP,@TENHP)";
            command = new SqlCommand(sqlINSERT, connection);
            command.Parameters.AddWithValue("MALHP", txtml.Text);
            command.Parameters.AddWithValue("TENLHP", txttl.Text);
            command.Parameters.AddWithValue("TENHP", txtthp.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE LOPHOCPHAN SET MALHP=@MALHP,TENLHP=@TENLHP,TENHP=@TENHP WHERE MALHP=@MALHP ";
            command = new SqlCommand(sqlEDIT, connection);
            command.Parameters.AddWithValue("MALHP", txtml.Text);
            command.Parameters.AddWithValue("TENLHP", txttl.Text);
            command.Parameters.AddWithValue("TENHP", txtthp.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE LOPHOCPHAN WHERE MALHP=@MALHP";
            command = new SqlCommand(sqlDELETE, connection);

            command.Parameters.AddWithValue("MALHP", txtml.Text);
            command.Parameters.AddWithValue("TENLHP", txttl.Text);
            command.Parameters.AddWithValue("TENHP", txtthp.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlSEARCH = "select MALHP N'Mã lớp',TENLHP N'Tên lớp',TENHP N'Tên học phần' FROM LOPHOCPHAN WHERE MALHP = @MALHP";
            command = new SqlCommand(sqlSEARCH, connection);

            command.Parameters.AddWithValue("MALHP", txttk.Text);


            command.ExecuteNonQuery();

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_LHP.DataSource = table;
        }

        private void DTV_LHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CHITIETHOCPHAN a = new CHITIETHOCPHAN();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frmindanhsach a = new Frmindanhsach();
            a.Show();

        }
    }
}
