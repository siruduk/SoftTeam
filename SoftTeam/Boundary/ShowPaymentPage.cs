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

        private void PaymentLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
