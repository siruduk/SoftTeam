using SoftTeam.Control;
using SoftTeam.Entity;
using System;
using System.Windows.Forms;

namespace SoftTeam.Boundary
{
    public partial class PaymentPage : Form
    {
        ItemManagementSystem IMS = new ItemManagementSystem();
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            IMS.SetPaymentListView(PaymentLV, 0);
        }

        private void PaymentLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaymentLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = PaymentLV.SelectedItems[0];

                categoryTB.Text = selectedItem.SubItems[2].Text;
                ItemTB.Text = selectedItem.SubItems[3].Text;
                AmountTB.Text = selectedItem.SubItems[4].Text;
                PriceTB.Text = selectedItem.SubItems[5].Text;
                calcPriceTB.Text = (int.Parse(PriceTB.Text) * int.Parse(AmountTB.Text)).ToString();
                DeptTB.Text = selectedItem.SubItems[1].Text;
                RemarkTB.Text= selectedItem.SubItems[6].Text;
            }
        }

        private void AcceptBT_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = PaymentLV.SelectedItems[0];
            MessageBox.Show(selectedItem.SubItems[0].Text);

            IMS.UpdatePayment(int.Parse(selectedItem.SubItems[0].Text), 1);
            IMS.SetPaymentListView(PaymentLV, 0);
            IMS.AddAmount(categoryTB.Text, ItemTB.Text, int.Parse(AmountTB.Text));
        }

        private void ReturnBT_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = PaymentLV.SelectedItems[0];
            IMS.UpdatePayment(int.Parse(selectedItem.SubItems[0].Text), 2);
            IMS.SetPaymentListView(PaymentLV, 0);
        }
    }
}
