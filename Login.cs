using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void B_LOGIN_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "shalby" & txt_pass.Text == "123456")
            {

                Calculator c = new Calculator();
                this.Hide();
                c.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry, wrong username or password.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
