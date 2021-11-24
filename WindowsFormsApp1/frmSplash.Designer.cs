
namespace WindowsFormsApp1
{
    partial class frmSplash
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnPupils = new System.Windows.Forms.Button();
            this.tmpButton = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hello, world!";
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.btnQuiz);
            this.pnlItems.Controls.Add(this.btnPupils);
            this.pnlItems.Controls.Add(this.tmpButton);
            this.pnlItems.Location = new System.Drawing.Point(12, 78);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(200, 360);
            this.pnlItems.TabIndex = 1;
            // 
            // btnQuiz
            // 
            this.btnQuiz.Location = new System.Drawing.Point(3, 3);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(94, 94);
            this.btnQuiz.TabIndex = 0;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnPupils
            // 
            this.btnPupils.Location = new System.Drawing.Point(103, 3);
            this.btnPupils.Name = "btnPupils";
            this.btnPupils.Size = new System.Drawing.Size(94, 94);
            this.btnPupils.TabIndex = 1;
            this.btnPupils.Text = "Pupils";
            this.btnPupils.UseVisualStyleBackColor = true;
            this.btnPupils.Click += new System.EventHandler(this.btnPupils_Click);
            // 
            // tmpButton
            // 
            this.tmpButton.Location = new System.Drawing.Point(3, 103);
            this.tmpButton.Name = "tmpButton";
            this.tmpButton.Size = new System.Drawing.Size(94, 94);
            this.tmpButton.TabIndex = 2;
            this.tmpButton.Text = "Hello, world!";
            this.tmpButton.UseVisualStyleBackColor = true;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(13, 43);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(211, 32);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Please select a task.";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(287, 58);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(489, 360);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSplash";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlItems;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnPupils;
        private System.Windows.Forms.Button tmpButton;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}