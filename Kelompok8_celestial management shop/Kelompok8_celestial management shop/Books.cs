using Kelompok8_Book;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelompok8_celestial_management_shop
{
    public partial class Books : Form
    {
        public Books()
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
        private void Filter()
        {
            Con.Open();
            string query = "SELECT * FROM `booktbl` where BCat='" + CatTbSearchTb.SelectedItem.ToString() + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAuthorTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO `booktbl` (`Bid`, `BTitle`, `BAuthor`, `BCat`, `BQty`, `BPrice`) VALUES (' ','" + BTitleTb.Text + "','" + BAuthorTb.Text + "','" + BCatCb.SelectedItem.ToString() + "'," + QtyTb.Text + "," + PriceTb.Text + ")";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Reset()
        {
            BId.Text = " ";
            BTitleTb.Text = "";
            BAuthorTb.Text = "";
            BCatCb.SelectedIndex = -1;
            QtyTb.Text = "";
            PriceTb.Text = "";
        }




        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ResetFilter_Click(object sender, EventArgs e)
        {
            populate();
            CatTbSearchTb.SelectedIndex = -1;
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (BId.Text == "")
            {
                MessageBox.Show("Enter Id Book");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from `booktbl` where `booktbl`.`Bid` =" + BId.Text + "";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfuly");
                    Con.Close();
                    populate();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CatTbSearchTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BookDGV.Rows[e.RowIndex];
                BTitleTb.Text = row.Cells["BTitle"].Value.ToString();
                BAuthorTb.Text = row.Cells["BAuthor"].Value.ToString();
                BCatCb.SelectedItem = row.Cells["BCat"].Value.ToString();
                QtyTb.Text = row.Cells["BQty"].Value.ToString();
                PriceTb.Text = row.Cells["BPrice"].Value.ToString();
                if (BTitleTb.Text == " ")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(row.Cells["BId"].Value.ToString());
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAuthorTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE `booktbl` SET `BTitle` = '" + BTitleTb.Text + "', `BAuthor` = '" + BAuthorTb.Text + "', `BCat` = '" + BCatCb.SelectedItem.ToString() + "', `BQty` = " + QtyTb.Text + ", `BPrice` = " + PriceTb.Text + " WHERE `booktbl`.`Bid` =" + key + " ";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            users obj = new users();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();    
            obj.Show();
            this.Hide();
        }
    }
}
