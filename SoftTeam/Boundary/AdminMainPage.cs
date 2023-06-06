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
            IMP.Show();
        }
    }
}
