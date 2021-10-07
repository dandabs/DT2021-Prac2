using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "student";
            string password = "pass";
            if (tbxUsername.Text == username && tbxPassword.Text == password)
            {
                Program.sessionUser = tbxUsername.Text;
                Form frmSplash = new frmSplash();
                frmSplash.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Error",
                    "Incorrect username or password.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
