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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            int intHourNow = System.DateTime.Now.Hour;
            if (intHourNow >= 20) lblTitle.Text = "Good night, " + Program.sessionUser + ".";
            if (intHourNow >= 16) lblTitle.Text = "Good evening, " + Program.sessionUser + ".";
            if (intHourNow >= 12) lblTitle.Text = "Good afternoon, " + Program.sessionUser + ".";
            if (intHourNow >= 0) lblTitle.Text = "Good morning, " + Program.sessionUser + ".";
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {

        }
    }
}
