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
        Account account=new Account();
        List<Account> accounts;


        public void AddItem(ItemAddPage IAP)
        {
            item.Category = IAP.CategoryCB.Text;
            item.Name = IAP.NameTB.Text;
            item.Remark = IAP.RemarkTB.Text;
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
        public bool CheckItem(string category, string itemName)
        {
            items = DBA.SelectItem();
            foreach(Item i in items)
            {
                if (i.Category == category && i.Name == itemName) return false;          
            }
            return true;
        }
        public void UseAmount(ListViewItem i,int n, string remark)
        {
            item.Category = i.SubItems[0].Text;
            item.Name = i.SubItems[1].Text;
            item.Amount = int.Parse(i.SubItems[3].Text) + n;
            if (DBA.UpdateItem(item))
            {
                InsertUsedLog(i, n*-1, remark);
            }
        }
        public void AddAmount(string category, string name, int Amount)
        {
            item.Category = category;
            item.Name = name;
            item.Amount = Amount;
            DBA.UpdateItem(item);
        }
        public void SetCategoryComboBox(ComboBox CCB)
        {
            category = DBA.SelectCategory();
            CCB.Items.Clear();
            CCB.Items.Add("전체");
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
                if (category != "전체")
                    if (i.Category.Trim() != category.Trim())
                    {
                        continue;
                    }
                ListViewItem item = new ListViewItem(i.Category);

                item.SubItems.Add(i.Name);
                item.SubItems.Add((i.Price).ToString());
                item.SubItems.Add((i.Amount).ToString());
                item.SubItems.Add(i.Remark);
                ILV.Items.Add(item);
            }
        }
        public bool CheckCategory(string cate)
        {
            category = DBA.SelectCategory();
            foreach (string i in category)
                if (i == cate) return false;
            return true;
        }
        public void InsertCategory(string cate) 
        { 
            DBA.InsertCategory(cate);
        }
        public void RequirePayment(ListViewItem i, int n, string remark)
        {
            SetTestAccount();
            int num = Program.rand.Next(0, 10);
            payment.category = i.SubItems[0].Text;
            payment.name = i.SubItems[1].Text;
            payment.price = int.Parse(i.SubItems[2].Text);
            payment.remark = remark;
            payment.requirmentAmount = n;
            payment.dept = accounts[num].dept;
            DBA.InsertPayment(payment);
        }
        public void SetPaymentListView(ListView ILV, int status = -1,string dept="전체")
        {
            payments = DBA.SelectPayment();
            ILV.Items.Clear();
            ILV.View = View.Details;

            foreach (Payment i in payments)
            {
                if (status != -1)
                    if (i.status != status)
                        continue;
                if (dept != "전체")
                    if (dept != i.dept)
                        continue;

                ListViewItem item = new ListViewItem(i.no.ToString());
                item.SubItems.Add(i.dept);
                item.SubItems.Add(i.category);
                item.SubItems.Add(i.name);
                item.SubItems.Add(i.requirmentAmount.ToString());
                item.SubItems.Add(i.price.ToString());
                item.SubItems.Add(i.remark);
                if (i.status == 0)
                    item.SubItems.Add("결제 대기");
                else if (i.status == 1)
                    item.SubItems.Add("승인");
                else if (i.status == 2)
                    item.SubItems.Add("반려");
                ILV.Items.Add(item);
            }

        }
        public void UpdatePayment(int no, int status)
        {
            DBA.UpdatePayment(no, status);
        }
        public void InsertUsedLog(ListViewItem i, int n, string remark)
        {
            SetTestAccount();
            int num = Program.rand.Next(0,10);
            usedLog.Category = i.SubItems[0].Text;
            usedLog.ItemName = i.SubItems[1].Text; 
            usedLog.Remark = remark; 
            usedLog.UsedAmount = n;
            usedLog.Dept = accounts[num].dept;
            DBA.InsertUsedLog(usedLog);
        }
        public void SetUsedLogListView(ListView ULV, string category, string dept)
        {
            usedLogs = DBA.SelectUsedLog();
            ULV.Items.Clear();
            ULV.View = View.Details;

            foreach (UsedLog i in usedLogs)
            {
                if (category != "전체")
                    if (i.Category.Trim() != category.Trim())
                    {
                        continue;
                    }
                if (dept != "전체")
                    if (dept != i.Dept)
                        continue;
                ListViewItem item = new ListViewItem(i.No.ToString());
                item.SubItems.Add(i.Category);
                item.SubItems.Add(i.ItemName);
                item.SubItems.Add(i.UsedAmount.ToString());
                item.SubItems.Add(i.Dept);
                item.SubItems.Add(i.Remark);
                item.SubItems.Add(i.Date);
                
                ULV.Items.Add(item);
            }
        }
        public void SetTestAccount()
        {
            List<string> depts= new List<string>();
            depts.Add("기획팀");
            depts.Add("인사팀");
            depts.Add("총무팀");
            depts.Add("회계팀");
            depts.Add("전산팀");
            accounts = new List<Account>();
            for (int i=0;i<10;i++)
            {
                Account a = new Account();
                a.id = "Test" + (i+1);
                a.dept = depts[i % 5];
                a.pw = 1234;
                accounts.Add(a);
            }
        } // 계정 관련 기능을 구현하지 않아 테스트용 계정정보 생성 및 저장
    }
}
