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
    public partial class SINHVIEN : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-TA85D1G\SQLEXPRESS;Initial Catalog=QLPhongMay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void hienthi()
        {
            command = connection.CreateCommand();
            command.CommandText = "select maSV N'Mã Sinh Viên',hotenSV N'Họ Tên',ngaysinhSV N'Ngày Sinh',gioitinhSV N'Giới Tính',diachiSV N'Địa Chỉ' from SINHVIEN";         
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
           DTV_SV.DataSource = table;
        }
        public SINHVIEN()
        {
            InitializeComponent();
        }
        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO SINHVIEN(MASV,HOTENSV,NGAYSINHSV,GIOITINHSV,DIACHISV) VALUES (@MASV,@HOTENSV,@NGAYSINHSV,@GIOITINHSV,@DIACHISV)";
            command = new SqlCommand(sqlINSERT, connection);
            command.Parameters.AddWithValue("maSV", txtmsv.Text);
            command.Parameters.AddWithValue("hotenSV", txtten.Text);
            command.Parameters.AddWithValue("ngaysinhSV", txtns.Text);
            command.Parameters.AddWithValue("gioitinhSV", txtgt.Text);
            command.Parameters.AddWithValue("diachiSV", txtdiachi.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE SINHVIEN SET MASV=@MASV, HOTENSV=@HOTENSV,NGAYSINHSV=@NGAYSINHSV, GIOITINHSV=@GIOITINHSV , DIACHISV=@DIACHISV WHERE MASV=@MASV";
            command = new SqlCommand(sqlEDIT, connection);
            command.Parameters.AddWithValue("maSV", txtmsv.Text);
            command.Parameters.AddWithValue("hotenSV", txtten.Text);
            command.Parameters.AddWithValue("ngaysinhSV", txtns.Text);
            command.Parameters.AddWithValue("gioitinhSV", txtgt.Text);
            command.Parameters.AddWithValue("diachiSV", txtdiachi.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM SINHVIEN WHERE MASV=@MASV";
            command = new SqlCommand(sqlDELETE, connection);
            command.Parameters.AddWithValue("maSV", txtmsv.Text);
            command.Parameters.AddWithValue("hotenSV", txtten.Text);
            command.Parameters.AddWithValue("ngaysinhSV", txtns.Text);
            command.Parameters.AddWithValue("gioitinhSV", txtgt.Text);
            command.Parameters.AddWithValue("diachiSV", txtdiachi.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hienthi();
        }

      

        private void BTNTK_Click(object sender, EventArgs e)
        {
            string sqlSEARCH = "select maSV N'Mã Sinh Viên',hotenSV N'Họ Tên',ngaysinhSV N'Ngày Sinh',gioitinhSV N'Giới Tính',diachiSV N'Địa Chỉ' FROM SINHVIEN WHERE MASV=@MASV";
            command = new SqlCommand(sqlSEARCH, connection);

            command.Parameters.AddWithValue("MASV", txttimkiem.Text);


            command.ExecuteNonQuery();

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_SV.DataSource = table;
        }

        private void DTV_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmsv_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

