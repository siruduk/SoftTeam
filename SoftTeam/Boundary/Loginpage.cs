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

        private void TextChanged(object sender, EventArgs e)
        {
            if (IdTB.Text.Length > 0 && IdTB.Text.Length > 0)
            {
                UserBT.Enabled = true;
                AdminBT.Enabled = true;
            }
            else
            {
                UserBT.Enabled = false;
                AdminBT.Enabled = false;
            }
        }
    }
}
