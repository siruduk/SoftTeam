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
            IMP.SetUsedLogListView(UsedLogLV,CategoryCB.Text);
            IMP.SetCategoryComboBox(CategoryCB);
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            IMP.SetUsedLogListView(UsedLogLV,CategoryCB.Text,SearchTB.Text);
        }

        private void CategoryCB_SelectedValueChanged(object sender, EventArgs e)
        {
            IMP.SetUsedLogListView(UsedLogLV, CategoryCB.Text, SearchTB.Text);
        }
    }
}
