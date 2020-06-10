using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL1
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SINHVIEN a = new SINHVIEN();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOPHP a = new LOPHP();
            a.Show();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
