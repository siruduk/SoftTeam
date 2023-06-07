using System;
using System.Windows.Forms;
using SoftTeam.Boundary;

namespace SoftTeam.Boundary
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void UserBT_Click(object sender, EventArgs e)
        {
            UserMainPage UMP = new UserMainPage();
            UMP.ShowDialog();
            Close();
        }

        private void AdminBT_Click(object sender, EventArgs e)
        {
            AdminMainPage AMP = new AdminMainPage();
            AMP.ShowDialog();
            Close();
        }
    }
}
