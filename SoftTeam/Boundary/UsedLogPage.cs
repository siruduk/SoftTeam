using System;
using System.Windows.Forms;
using SoftTeam.Control;

namespace SoftTeam.Boundary
{
    public partial class UsedLogPage : Form
    {
        ItemManagementSystem IMP = new ItemManagementSystem();
        public UsedLogPage()
        {
            InitializeComponent();
        }

        private void UsedLogPage_Load(object sender, EventArgs e)
        {
            IMP.SetUsedLogListView(UsedLogLV, CategoryCB.Text, DeptCB.Text);
            IMP.SetCategoryComboBox(CategoryCB);
            CategoryCB.SelectedIndex = 0;
            DeptCB.SelectedIndex = 0;
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            IMP.SetUsedLogListView(UsedLogLV,CategoryCB.Text,DeptCB.Text);
        }

        private void CategoryCB_SelectedValueChanged(object sender, EventArgs e)
        {
            IMP.SetUsedLogListView(UsedLogLV, CategoryCB.Text, DeptCB.Text);
        }

        private void DeptCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMP.SetUsedLogListView(UsedLogLV, CategoryCB.Text, DeptCB.Text);
        }
    }
}
