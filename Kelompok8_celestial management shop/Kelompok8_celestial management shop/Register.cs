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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        MySqlConnection Con = new MySqlConnection("datasource=127.0.0.1; port=3307; username=root; password=; database=bookshopdb");

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || UPassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO `user` (`userId`, `username`, `Userphone`, `Useradd`, `userpass`) VALUES (' ','" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + UPassTb.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register Successfully");
                    Con.Close();
                    Login obj = new Login();
                    obj.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
