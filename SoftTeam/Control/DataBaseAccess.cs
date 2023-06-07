using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using SoftTeam.Entity;

namespace SoftTeam.Control
{
    internal class DataBaseAccess
    {
        string _connectionAddress = "Server = localhost; Port=3306;Database=soft;Uid=root;Pwd=1234";

        public List<Item> SelectItem()
        {
            List<Item> items = new List<Item>();
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM item");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {
                        Item item = new Item();
                        item.Category = table["Category"].ToString();
                        item.Name = table["Name"].ToString();
                        item.Standard = table["Standard"].ToString();
                        item.Price = int.Parse(table["Price"].ToString());
                        item.Amount = int.Parse(table["Amount"].ToString());
                        items.Add(item);
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return items;
        }
        public void InsertItem(Item i)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO item (Category, Name, Standard, Price, Amount) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", i.Category,i.Name,i.Standard,i.Price,i.Amount);
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public List<string> SelectCategory()
        {
            List<string> category= new List<string>();
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM Categorys");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {
                        category.Add(table["Category"].ToString());
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return category;
        }
        public void DelItem(Item i)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string deleteQuery = string.Format("DELETE FROM item WHERE (Category = '{0}')and (name = '{1}');",i.Category,i.Name);

                    MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public bool UpdateItem(Item i)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string updateQuery = string.Format("UPDATE Item SET Amount={0} WHERE Category='{1}' and Name = '{2}';", i.Amount, i.Category,i.Name);
                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to update data.");
                        return false;
                    }
                    else
                        return true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }
        public List<UsedLog> SelectUsedLog(string Search)
        {
            List<UsedLog> list = new List<UsedLog>();
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM UsedLog where item like '%{0}%'", Search);

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {
                        UsedLog usedLog = new UsedLog();
                        usedLog.Category = table["Category"].ToString();
                        usedLog.No = int.Parse(table["No"].ToString());
                        usedLog.Date = table["Date"].ToString();
                        usedLog.ItemName = table["item"].ToString();
                        usedLog.UsedAmount = int.Parse(table["UsedAmount"].ToString());
                        usedLog.Remark = table["Remark"].ToString();
                        usedLog.Dept = table["Dept"].ToString();
                        list.Add(usedLog);
                    }
                    table.Close();
                }
                return list;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return list;
            }
        }
        public void InsertUsedLog(UsedLog usedLog)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO usedlog (Category, Item, UsedAmount, Remark, Dept) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                        usedLog.Category, usedLog.ItemName, usedLog.UsedAmount, usedLog.Remark, usedLog.Dept);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public List<Payment> SelectPayment()
        {
            List<Payment> list = new List<Payment>();

            return list;
        }
        public void UpdatePayment(int no,int status)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string updateQuery = string.Format("UPDATE Payment SET Status = {0} WHERE No = {0};", status, no);
                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to update data.");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public void InsertPayment(Payment payment)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO Payment (Category, Name, requirmentAmount, Remark, Price, id) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', 'test');",
                        payment.category, payment.name, payment.requirmentAmount, payment.remark,payment.price);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
