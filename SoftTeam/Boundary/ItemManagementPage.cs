using System;
using System.Windows.Forms;
using SoftTeam.Control;

namespace SoftTeam.Boundary
{
    public partial class ItemManagementPage : Form
    {
        ItemManagementSystem IMS = new ItemManagementSystem();

        public ItemManagementPage()
        {
            InitializeComponent();
        }

        public void SetUser()
        {
            AddBT.Visible = false;
            DelBT.Visible = false;
        }
        private void AddBT_Click(object sender, EventArgs e)
        {
            ItemAddPage IAP = new ItemAddPage();
            IAP.ShowDialog();
            IMS.SetCategoryComboBox(CategoryCB);
            IMS.SetItemListView(ItemLV,CategoryCB.Text);
            CategoryCB.SelectedIndex = 0;
            DelBT.Enabled = false;
            UsedBT.Enabled = false;
            RequireBT.Enabled = false;
        }
        private void DelBT_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = ItemLV.SelectedItems[0];
            IMS.DelItem(selectedItem);
            IMS.SetItemListView(ItemLV, CategoryCB.Text);
            NameTB.Text = "";
            AmountTB.Text = "";
            RemarkTB.Text = "";
            DelBT.Enabled = false;
            UsedBT.Enabled = false;
            RequireBT.Enabled = false;
            MessageBox.Show("삭제가 완료되었습니다.");
        }
        private void UsedBT_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = ItemLV.SelectedItems[0];
            if (int.Parse(selectedItem.SubItems[3].Text) - int.Parse(AmountTB.Text) < 0)
            {
                MessageBox.Show("재고보다 많은 수량은 입력할 수 없습니다..");
                NameTB.Text = "";
                AmountTB.Text = "";
                RemarkTB.Text = "";
                DelBT.Enabled = false;
                UsedBT.Enabled = false;
                RequireBT.Enabled = false;
                return;
            }
            IMS.UseAmount(selectedItem, (int.Parse(AmountTB.Text))*-1, RemarkTB.Text);
            IMS.SetItemListView(ItemLV, CategoryCB.Text);
            NameTB.Text = "";
            AmountTB.Text = "";
            RemarkTB.Text = "";
            DelBT.Enabled = false;
            UsedBT.Enabled = false;
            RequireBT.Enabled = false;
            MessageBox.Show("소모처리가 완료되었습니다.");
        }
        private void RequireBT_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = ItemLV.SelectedItems[0];
            IMS.RequirePayment(selectedItem, int.Parse(AmountTB.Text),RemarkTB.Text);
            NameTB.Text = "";
            AmountTB.Text = "";
            RemarkTB.Text = "";
            DelBT.Enabled = false;
            UsedBT.Enabled = false;
            RequireBT.Enabled = false;
            MessageBox.Show("결제 요청이 완료되었습니다.");
        }
        private void ItemManagementPage_Load(object sender, EventArgs e)
        {
            IMS.SetCategoryComboBox(CategoryCB);
            IMS.SetItemListView(ItemLV,CategoryCB.Text);
            CategoryCB.SelectedIndex = 0;
            DelBT.Enabled = false;
            UsedBT.Enabled = false;
            RequireBT.Enabled = false;
        }
        private void ItemLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ItemLV.SelectedItems[0];

                NameTB.Text = selectedItem.SubItems[1].Text;
                AmountTB.Text = "";
                RemarkTB.Text = "";
                DelBT.Enabled = true;
            }
        }
        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTB.Text = "";
            AmountTB.Text = "";
            RemarkTB.Text = "";
            DelBT.Enabled = false;
            UsedBT.Enabled = false;
            RequireBT.Enabled = false;

            IMS.SetItemListView(ItemLV, CategoryCB.Text);
        }
        private void AmountTB_TextChanged(object sender, EventArgs e)
        {
            if (AmountTB.Text.Length > 0 && RemarkTB.Text.Length > 0)
            {
                UsedBT.Enabled = true;
                RequireBT.Enabled = true;

                ListViewItem selectedItem = ItemLV.SelectedItems[0];

                if (int.Parse(selectedItem.SubItems[3].Text) < int.Parse(AmountTB.Text))
                    UsedBT.Enabled = false;
            }
            else
            {
                UsedBT.Enabled = false;
                RequireBT.Enabled = false;
            }
        }
        private void RemarkTB_TextChanged(object sender, EventArgs e)
        {
            if (AmountTB.Text.Length > 0 && RemarkTB.Text.Length > 0)
            {
                UsedBT.Enabled = true;
                RequireBT.Enabled = true;
            }
            else
            {
                UsedBT.Enabled = false;
                RequireBT.Enabled = false;
            }
        }
        private void AmountTB_KeyPress(object sender, KeyPressEventArgs e)//입력할때 숫자,백스페이스만 입력받음
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void ReloadBT_Click(object sender, EventArgs e)
        {
            IMS.SetCategoryComboBox(CategoryCB);
            IMS.SetItemListView(ItemLV, CategoryCB.Text);
            CategoryCB.SelectedIndex = 0;
        }
    }
}
