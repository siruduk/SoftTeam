using System;
using System.Windows.Forms;
using SoftTeam.Control;
using SoftTeam.Boundary;


namespace SoftTeam.Boundary
{
    public partial class ItemAddPage : Form
    {
        ItemManagementSystem IMS = new ItemManagementSystem();

        public ItemAddPage()
        {
            InitializeComponent();
            SaveBT.Enabled = false;
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            IMS.AddItem(this);
            MessageBox.Show("추가되었습니다.");
            Close();
        }

        private void ItemAddPage_Load(object sender, EventArgs e)
        {
            IMS.SetCategoryComboBox(CategoryCB);
            CategoryCB.SelectedIndex = 0;
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (CategoryCB.Text.Length > 0 && NameTB.Text.Length > 0 && RemarkTB.Text.Length > 0 && AmountTB.Text.Length > 0 && PriceTB.Text.Length > 0)
            {
                CheckBT.Enabled = true;
                SaveBT.Enabled = false;
            }
            else
            {
                SaveBT.Enabled = false;
                CheckBT.Enabled = false;
            }
        }

        private void AddCategoryBT_Click(object sender, EventArgs e)
        {
            AddCategoryPage ACP = new AddCategoryPage();
            ACP.ShowDialog();
        }

        private void CheckBT_Click(object sender, EventArgs e)
        {
            if (IMS.CheckItem(CategoryCB.Text, NameTB.Text))
            {
                SaveBT.Enabled = true;
                MessageBox.Show("추가 가능한 품목입니다.");
            }
            else 
                MessageBox.Show("이미 있는 품목입니다.");

        }
    }
}
