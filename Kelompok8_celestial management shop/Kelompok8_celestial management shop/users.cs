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
using Xamarin.Forms;

namespace Kelompok8_celestial_management_shop
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            populate();
        }
        MySqlConnection Con = new MySqlConnection("datasource=127.0.0.1; port=3307; username=root; password=; database=bookshopdb");

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM `user`";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void Reset()
        {
            UnameTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
            PassTb.Text = "";
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO `user` (`userId`, `username`, `Userphone`, `Useradd`, `userpass`) VALUES (' ','" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + PassTb.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
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

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.UserDGV.Rows[e.RowIndex];
                UnameTb.Text = row.Cells["username"].Value.ToString();
                PhoneTb.Text = row.Cells["Userphone"].Value.ToString();
                AddTb.Text = row.Cells["Useradd"].Value.ToString();
                PassTb.Text = row.Cells["userpass"].Value.ToString();
                if (UnameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(row.Cells["UserId"].Value.ToString());
                }
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "delete from `user` where `userId` =" + key + "";
                MySqlCommand cmd = new MySqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update `user` set `username` = '" + UnameTb.Text + "', `Userphone` = '" + PhoneTb.Text + "', `Useradd` = '" + AddTb.Text + "', `userpass` = '" + PassTb.Text + "'  where `userId` =" + key + "";
                MySqlCommand cmd = new MySqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show(); this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show(); this.Close();   
        }
    }
}
