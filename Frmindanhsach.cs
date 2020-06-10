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
    public partial class Frmindanhsach : Form
    {
        public Frmindanhsach()
        {
            InitializeComponent();
        }

        private void Frmindanhsach_Load(object sender, EventArgs e)
        {
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataSet1.CT_HOCPHAN' table. You can move, or remove it, as needed.
            this.CT_HOCPHANTableAdapter.Fill(this.DataSet1.CT_HOCPHAN,txttimkiem.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
