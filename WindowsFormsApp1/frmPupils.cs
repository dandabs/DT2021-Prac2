using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPupils : Form
    {
        public frmPupils()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void frmPupils_Load(object sender, EventArgs e)
        {
            refreshPupils();
        }

        private void refreshPupils()
        {

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope\"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope\");
            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope\pupils.txt"))
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope\pupils.txt").Close();
            }

            string strFileLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope\pupils.txt";

            try
            {
       
                StreamReader strReader = new StreamReader(strFileLoc);
                string[] totalData = new String[File.ReadAllLines(strFileLoc).Length];
                totalData = strReader.ReadLine().Split(',');
                grdPupils.Rows.Clear();
                while (!strReader.EndOfStream)
                {
                    totalData = strReader.ReadLine().Split(',');
                    grdPupils.Rows.Add(totalData[0], totalData[1], totalData[2], totalData[3], totalData[4], totalData[5], totalData[6], totalData[7], totalData[8], totalData[9], totalData[10], totalData[11]);
                }
                strReader.Close();

            } catch (NullReferenceException e)
            {
                string strContents = File.ReadAllText(strFileLoc);
            }
        }

        private void grdPupils_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshPupils();
        }
    }
}
