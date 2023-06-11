using SoftTeam.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTeam.Boundary
{
    public partial class AddCategoryPage : Form
    {
        ItemManagementSystem IMS = new ItemManagementSystem();
        public AddCategoryPage()
        {
            InitializeComponent();
        }

        private void CategoryTB_TextChanged(object sender, EventArgs e)
        {
            if(CategoryTB.Text.Length > 0) 
            {
                CheckBT.Enabled = true;
            }
            else 
            {             
                CheckBT.Enabled = false; 
            }
        }

        private void CheckBT_Click(object sender, EventArgs e)
        {
            if(IMS.CheckCategory(CategoryTB.Text))
                AddBT.Enabled = true;
            else 
            {
                MessageBox.Show("이미 있는 카테고리 입니다.");
                AddBT.Enabled = false;
            }
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            IMS.InsertCategory(CategoryTB.Text);
            MessageBox.Show("추가되었습니다.");
            Close();
        }
    }
}
