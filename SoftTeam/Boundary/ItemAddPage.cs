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
            SaveButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            IMS.AddItem(this);
        }

        private void ItemAddPage_Load(object sender, EventArgs e)
        {
            IMS.SetCategoryComboBox(CategoryCB);
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
            if (CategoryCB.Text.Length > 0 && NameTB.Text.Length > 0 && StandardTB.Text.Length > 0 && AmountTB.Text.Length > 0 && PriceTB.Text.Length > 0)
                SaveButton.Enabled = true;
            else 
                SaveButton.Enabled=false;
        }
    }
}
