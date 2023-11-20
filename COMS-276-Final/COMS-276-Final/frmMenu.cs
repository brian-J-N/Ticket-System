using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS_276_Final
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEventCreator_Click(object sender, EventArgs e)
        {
            frmEventCreator ViewEventCreator = new frmEventCreator();
            ViewEventCreator.ShowDialog();
        }

        private void btnTicketPortal_Click(object sender, EventArgs e)
        {
            frmTicketPortal ViewTicketPortal = new frmTicketPortal();
            ViewTicketPortal.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReports ViewReports = new frmReports();
            ViewReports.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
