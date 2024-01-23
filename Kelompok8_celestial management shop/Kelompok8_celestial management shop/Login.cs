using Kelompok8_celestial_management_shop;
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

namespace Kelompok8_Book
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection Con = new MySqlConnection("datasource=127.0.0.1; port=3307; username=root; password=; database=bookshopdb");

        public static string userName = " ";

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UnameTb.Text.ToString();
                string password = UPassTb.Text.ToString();
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("no empty field allowed");

                }
                else
                {
                    Con.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM user WHERE username = @username AND userpass = @password", Con);
                    mySqlCommand.Parameters.AddWithValue("@username", username);
                    mySqlCommand.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        userName = UnameTb.Text;
                        MessageBox.Show("Login Success" +
                            "Wellcome");
                        user_bookshop obj = new user_bookshop();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }

                    Con.Close();
                }
            }
            catch (Exception ex) { }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLog obj = new AdminLog();
            obj.Show();
            this.Hide();
        }
    }
}
