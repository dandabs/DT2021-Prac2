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
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope\pupils.txt");
            }

            try
            {

                string strFileLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SkiSlope\pupils.txt";
                StreamReader strReader = new StreamReader(strFileLoc);
                string[] totalData = new String[File.ReadAllLines(strFileLoc).Length];
                totalData = strReader.ReadLine().Split(',');
                while (!strReader.EndOfStream)
                {
                    totalData = strReader.ReadLine().Split(',');
                    grdPupils.Rows.Add(totalData[0], totalData[1], totalData[2], totalData[3], totalData[4], totalData[5]);
                }

            } catch (NullReferenceException e)
            {

            }
        }

        private void grdPupils_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
