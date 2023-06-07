using System;
using System.Windows.Forms;

namespace SoftTeam.Boundary
{
    public partial class UserMainPage : Form
    {
        public UserMainPage()
        {
            InitializeComponent();
        }

        private void ItemManagementBT_Click(object sender, EventArgs e)
        {
            ItemManagementPage IMP = new ItemManagementPage();
            IMP.SetUser();
            IMP.Show();
        }

        private void UsedLogBT_Click(object sender, EventArgs e)
        {
            UsedLogPage ULP = new UsedLogPage();
            ULP.ShowDialog();
        }

        private void PaymentManagementBT_Click(object sender, EventArgs e)
        {
            ShowPaymentPage PP = new ShowPaymentPage();
            PP.ShowDialog();
        }
    }
}
