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
    public partial class ShowPaymentPage : Form
    {
        ItemManagementSystem IMS = new ItemManagementSystem();
        public ShowPaymentPage()
        {
            InitializeComponent();
            StatusCB.SelectedIndex = 0;
            DeptCB.SelectedIndex = 0;
            IMS.SetPaymentListView(PaymentLV);
        }

        private void StatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status = 2;
            if (StatusCB.Text == "전체") status = -1;
            else if (StatusCB.Text == "결제 대기") status = 0;
            else if (StatusCB.Text == "승인") status = 1;
            else if (StatusCB.Text == "반려") status = 2;

            IMS.SetPaymentListView(PaymentLV, status, DeptCB.Text);
        }

        private void DeptCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status = 2;
            if (StatusCB.Text == "전체") status = -1;
            else if (StatusCB.Text == "결제 대기") status = 0;
            else if (StatusCB.Text == "승인") status = 1;
            else if (StatusCB.Text == "반려") status = 2;

            IMS.SetPaymentListView(PaymentLV, status, DeptCB.Text);
        }
    }
}
