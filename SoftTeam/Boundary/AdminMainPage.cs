using System;

using System.Windows.Forms;
using SoftTeam.Boundary;

namespace SoftTeam.Boundary
{
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void UsedLogBT_Click(object sender, EventArgs e)
        {
            UsedLogPage ULP = new UsedLogPage();
            ULP.ShowDialog();
        }

        private void ItemManagementBT_Click(object sender, EventArgs e)
        {
            ItemManagementPage IMP = new ItemManagementPage();
            IMP.ShowDialog();
        }

        private void PaymentManagementBT_Click(object sender, EventArgs e)
        {
            PaymentPage PP = new PaymentPage();
            PP.ShowDialog();
        }

        private void PaymentLogBT_Click(object sender, EventArgs e)
        {
            ShowPaymentPage PP = new ShowPaymentPage();
            PP.ShowDialog();
        }
    }
}
