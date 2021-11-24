using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            // update tile to time of day + session user's uname/uid
            int intHourNow = System.DateTime.Now.Hour;
            if (intHourNow >= 20) lblTitle.Text = "Good night, " + Program.sessionUser + ".";
            if (intHourNow >= 16) lblTitle.Text = "Good evening, " + Program.sessionUser + ".";
            if (intHourNow >= 12) lblTitle.Text = "Good afternoon, " + Program.sessionUser + ".";
            if (intHourNow >= 0) lblTitle.Text = "Good morning, " + Program.sessionUser + ".";

            // update chart data from pupils file
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope";
            string file = "pupils.txt";

            string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
    path + ";Extended Properties=\"Text;HDR=No;FMT=Delimited\"";
            OleDbConnection conn = new OleDbConnection(conStr);

            string selectQr = "Select * from " + file;
            OleDbCommand cmd = new OleDbCommand(selectQr, conn);

            cmd.Connection.Open();
            OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            chart1.Series[0].Points.DataBindXY(reader, "0", reader, "2");
            chart1.Series[0].ChartType = SeriesChartType.Line;

            reader.Close();
            conn.Close();


        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {

        }

        private void btnPupils_Click(object sender, EventArgs e)
        {
            Form frmPupils = new frmPupils();
            frmPupils.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }



    }
}
