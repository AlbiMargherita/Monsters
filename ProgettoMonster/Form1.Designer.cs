namespace ProgettoMonster
{
    partial class Form1
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
            this.playerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pHpBar = new System.Windows.Forms.ProgressBar();
            this.eHpBar = new System.Windows.Forms.ProgressBar();
            this.pNameLbl = new System.Windows.Forms.Label();
            this.pPicture = new System.Windows.Forms.PictureBox();
            this.Epicture = new System.Windows.Forms.PictureBox();
            this.playerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.pPicture);
            this.playerPanel.Controls.Add(this.pNameLbl);
            this.playerPanel.Controls.Add(this.pHpBar);
            this.playerPanel.Location = new System.Drawing.Point(8, 8);
            this.playerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(223, 237);
            this.playerPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Epicture);
            this.panel1.Controls.Add(this.eHpBar);
            this.panel1.Location = new System.Drawing.Point(255, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 237);
            this.panel1.TabIndex = 13;
            // 
            // pHpBar
            // 
            this.pHpBar.Location = new System.Drawing.Point(11, 57);
            this.pHpBar.Margin = new System.Windows.Forms.Padding(2);
            this.pHpBar.Name = "pHpBar";
            this.pHpBar.Size = new System.Drawing.Size(202, 21);
            this.pHpBar.TabIndex = 14;
            this.pHpBar.Value = 100;
            // 
            // eHpBar
            // 
            this.eHpBar.Location = new System.Drawing.Point(11, 57);
            this.eHpBar.Margin = new System.Windows.Forms.Padding(2);
            this.eHpBar.Name = "eHpBar";
            this.eHpBar.Size = new System.Drawing.Size(202, 21);
            this.eHpBar.TabIndex = 0;
            this.eHpBar.Value = 100;
            // 
            // pNameLbl
            // 
            this.pNameLbl.AutoSize = true;
            this.pNameLbl.Location = new System.Drawing.Point(8, 7);
            this.pNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pNameLbl.Name = "pNameLbl";
            this.pNameLbl.Size = new System.Drawing.Size(69, 13);
            this.pNameLbl.TabIndex = 0;
            this.pNameLbl.Text = "Nome mostro";
            // 
            // pPicture
            // 
            this.pPicture.Location = new System.Drawing.Point(11, 83);
            this.pPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(202, 148);
            this.pPicture.TabIndex = 15;
            this.pPicture.TabStop = false;
            // 
            // Epicture
            // 
            this.Epicture.Location = new System.Drawing.Point(11, 83);
            this.Epicture.Margin = new System.Windows.Forms.Padding(2);
            this.Epicture.Name = "Epicture";
            this.Epicture.Size = new System.Drawing.Size(202, 148);
            this.Epicture.TabIndex = 16;
            this.Epicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.PictureBox pPicture;
        private System.Windows.Forms.Label pNameLbl;
        private System.Windows.Forms.ProgressBar pHpBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Epicture;
        private System.Windows.Forms.ProgressBar eHpBar;
    }
}
