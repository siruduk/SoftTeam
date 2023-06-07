using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using SoftTeam.Boundary;
using SoftTeam.Entity;

namespace SoftTeam.Control
{
    internal class ItemManagementSystem
    {
        DataBaseAccess DBA = new DataBaseAccess();
        Item item = new Item();
        List<string> category;
        List<Item> items;
        UsedLog usedLog = new UsedLog();
        List<UsedLog> usedLogs;
        Payment payment = new Payment();
        List<Payment> payments;
        Account acount=new Account();
        List<Account> Accounts;

        public void AddItem(ItemAddPage IAP)
        {
            item.Category = IAP.CategoryCB.Text;
            item.Name = IAP.NameTB.Text;
            item.Standard = IAP.StandardTB.Text;
            item.Price = int.Parse(IAP.PriceTB.Text);
            item.Amount = int.Parse(IAP.AmountTB.Text);
            DBA.InsertItem(item);
        }
        public void DelItem(ListViewItem i)
        {
            item.Category = i.SubItems[0].Text;
            item.Name = i.SubItems[1].Text;

            DBA.DelItem(item);
        }
        public void UpdateAmount(ListViewItem i,int n, string remark)
        {
            item.Category = i.SubItems[0].Text;
            item.Name = i.SubItems[1].Text;
            item.Amount = int.Parse(i.SubItems[3].Text) + n;
            if (DBA.UpdateItem(item))
            {
                InsertUsedLog(i, n*-1, remark);
            }
        }
        public void SetCategoryComboBox(ComboBox CCB)
        {
            category = DBA.SelectCategory();
            CCB.Items.Clear();
            CCB.Items.Add("");
            foreach (string ct in category)
                CCB.Items.Add(ct);
        }
        public void SetItemListView(ListView ILV,string category) 
        {
            items = DBA.SelectItem();
            ILV.Items.Clear();
            ILV.View = View.Details;

            foreach (Item i in items)
            {
                if (category != "")
                    if (i.Category.Trim() != category.Trim())
                    {
                        continue;
                    }
                ListViewItem item = new ListViewItem(i.Category);

                item.SubItems.Add(i.Name);
                item.SubItems.Add((i.Price).ToString());
                item.SubItems.Add((i.Amount).ToString());
                item.SubItems.Add(i.Standard);
                ILV.Items.Add(item);
            }
        }
        public void RequirePayment(ListViewItem i, int n, string remark)
        {
            payment.category = i.SubItems[0].Text;
            payment.name = i.SubItems[1].Text;
            payment.price = int.Parse(i.SubItems[2].Text);
            payment.remark = remark;
            payment.requirmentAmount = n;
            DBA.InsertPayment(payment);
        }
        public void InsertUsedLog(ListViewItem i, int n, string remark)
        {
            usedLog.Category = i.SubItems[0].Text;
            usedLog.ItemName = i.SubItems[1].Text; 
            usedLog.Remark = remark; 
            usedLog.UsedAmount = n;
            DBA.InsertUsedLog(usedLog);
        }
        public void SetUsedLogListView(ListView ULV, string category, string search = "")
        {
            usedLogs = DBA.SelectUsedLog(search);
            ULV.Items.Clear();
            ULV.View = View.Details;

            foreach (UsedLog i in usedLogs)
            {
                if (category != "")
                    if (i.Category.Trim() != category.Trim())
                    {
                        continue;
                    }
                ListViewItem item = new ListViewItem(i.No.ToString());
                item.SubItems.Add(i.Category);
                item.SubItems.Add(i.ItemName);
                item.SubItems.Add(i.UsedAmount.ToString());
                item.SubItems.Add(i.Remark);
                item.SubItems.Add(i.Date);

                ULV.Items.Add(item);
            }
        }
        public void SetTestAccount()
        {

        }
    }
}
