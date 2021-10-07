
namespace WindowsFormsApp1
{
    partial class frmPupils
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdPupils = new System.Windows.Forms.DataGridView();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPupilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pupilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmForename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSkiAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPupils)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPupils
            // 
            this.grdPupils.AllowUserToAddRows = false;
            this.grdPupils.AllowUserToDeleteRows = false;
            this.grdPupils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPupils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSurname,
            this.clmForename,
            this.clmDOB,
            this.clmClass,
            this.clmSkiAverage,
            this.clmQuiz});
            this.grdPupils.Location = new System.Drawing.Point(13, 72);
            this.grdPupils.Name = "grdPupils";
            this.grdPupils.ReadOnly = true;
            this.grdPupils.Size = new System.Drawing.Size(775, 366);
            this.grdPupils.TabIndex = 0;
            this.grdPupils.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPupils_CellContentClick);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(12, 24);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(134, 32);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "Pupil details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.pupilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "mnuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPupilToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // addPupilToolStripMenuItem
            // 
            this.addPupilToolStripMenuItem.Name = "addPupilToolStripMenuItem";
            this.addPupilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPupilToolStripMenuItem.Text = "Add Pupil";
            // 
            // pupilToolStripMenuItem
            // 
            this.pupilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.pupilToolStripMenuItem.Name = "pupilToolStripMenuItem";
            this.pupilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.pupilToolStripMenuItem.Text = "Pupil";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clmSurname
            // 
            this.clmSurname.HeaderText = "Surname";
            this.clmSurname.Name = "clmSurname";
            this.clmSurname.ReadOnly = true;
            // 
            // clmForename
            // 
            this.clmForename.HeaderText = "Forename";
            this.clmForename.Name = "clmForename";
            this.clmForename.ReadOnly = true;
            // 
            // clmDOB
            // 
            this.clmDOB.HeaderText = "Date of Birth";
            this.clmDOB.Name = "clmDOB";
            this.clmDOB.ReadOnly = true;
            // 
            // clmClass
            // 
            this.clmClass.HeaderText = "Class";
            this.clmClass.Name = "clmClass";
            this.clmClass.ReadOnly = true;
            // 
            // clmSkiAverage
            // 
            this.clmSkiAverage.HeaderText = "Slope Average";
            this.clmSkiAverage.Name = "clmSkiAverage";
            this.clmSkiAverage.ReadOnly = true;
            // 
            // clmQuiz
            // 
            this.clmQuiz.HeaderText = "Quiz Results";
            this.clmQuiz.Name = "clmQuiz";
            this.clmQuiz.ReadOnly = true;
            // 
            // frmPupils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grdPupils);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPupils";
            this.Text = "Pupils";
            this.Load += new System.EventHandler(this.frmPupils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPupils)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPupils;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addPupilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pupilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmForename;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSkiAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuiz;
    }
}