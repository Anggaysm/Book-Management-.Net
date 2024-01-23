using Kelompok8_Book;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelompok8_celestial_management_shop
{
    public partial class user_bookshop : Form
    {
        public user_bookshop()
        {
            InitializeComponent();
            populate();
        }
        MySqlConnection Con = new MySqlConnection("datasource=127.0.0.1; port=3307; username=root; password=; database=bookshopdb");
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM `booktbl`";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            try
            {
                Con.Open();
                string query = "UPDATE `booktbl` SET `BQty` = " + newQty + " WHERE `booktbl`.`Bid` =" + key + " ";
                MySqlCommand cmd = new MySqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int n = 0, GrdTotal = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                GrdTotal = GrdTotal + total;
                TotalBill.Text = "Rp " + GrdTotal + ".000";
            }
        }
        int key = 0, stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BookDGV.Rows[e.RowIndex];
                BTitleTb.Text = row.Cells["BTitle"].Value.ToString();
                PriceTb.Text = row.Cells["BPrice"].Value.ToString();
                if (BTitleTb.Text == " ")
                {
                    key = 0;
                    stock = 0;
                }
                else
                {
                    key = Convert.ToInt32(row.Cells["BId"].Value.ToString());
                    stock = Convert.ToInt32(row.Cells["BQty"].Value.ToString());
                }
            }
        }

        private void Reset()
        {
            BTitleTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            ClientNameTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column4"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column3"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos += 20;

            }
            e.Graphics.DrawString("Grand Total: Rp" + GrdTotal + ".000", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("********Celestial BookShop********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
        }

        private void PrintBill_Click(object sender, EventArgs e)
        {
            if (ClientNameTb.Text == "" || BTitleTb.Text == "")
            {
                MessageBox.Show("Sellect Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO `BillTbl` (`BillId`, `Uname`, `ClientName`, `Amout`) VALUES (' ','" + UserNameLb.Text + "','" + ClientNameTb.Text + "'," + GrdTotal + ")";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void user_bookshop_Load(object sender, EventArgs e)
        {
            UserNameLb.Text = Login.userName;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        
    }
}
