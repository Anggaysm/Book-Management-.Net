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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            users obj = new users();
            obj.Show();
            this.Hide();
        }
        MySqlConnection Con = new MySqlConnection("datasource=127.0.0.1; port=3307; username=root; password=; database=bookshopdb");
        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select sum(BQty) from Booktbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStock.Text = dt.Rows[0][0].ToString();
            MySqlDataAdapter sda1 = new MySqlDataAdapter("select sum(Amout) from billtbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountTotal.Text = dt1.Rows[0][0].ToString();
            MySqlDataAdapter sda2 = new MySqlDataAdapter("select count(*) from user", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UserTotal.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
