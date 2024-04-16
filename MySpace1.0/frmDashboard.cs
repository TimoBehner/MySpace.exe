using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySpace1._0
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            UserControlheutigeTermine userControlheutigeTermine = new UserControlheutigeTermine();
            flowLayoutPanel1.Controls.Add(userControlheutigeTermine);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            frmEventssehen frmEventssehen = new frmEventssehen();
            frmEventssehen.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmEventssehen frmEventssehen = new frmEventssehen();
            frmEventssehen.Show();
        }
    }
}
