using Kelompok8_Book;
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
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UPassTb.Text == "1234")
            {
                Books obj = new Books();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void Cencel_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
