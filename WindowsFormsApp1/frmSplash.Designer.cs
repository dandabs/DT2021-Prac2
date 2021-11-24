
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnPupils = new System.Windows.Forms.Button();
            this.tmpButton = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlItems.SuspendLayout();
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
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSplash";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.pnlItems.ResumeLayout(false);
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
    }
}