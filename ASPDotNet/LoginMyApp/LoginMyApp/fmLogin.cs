using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMyApp
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Length == 0)
            {
                MessageBox.Show("Username required");
                txtUser.Focus();//To send control back to username
            }
            else
            {
                MessageBox.Show("Welcome, " + txtUser.Text);
            }
        }
    }
}
