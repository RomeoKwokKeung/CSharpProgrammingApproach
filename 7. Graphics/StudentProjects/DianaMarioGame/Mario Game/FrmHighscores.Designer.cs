namespace Mario_Game
{
    partial class FrmScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScores));
            this.lblScores = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.LstScores = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScores
            // 
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Location = new System.Drawing.Point(176, 52);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(368, 254);
            this.lblScores.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(603, 300);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // LstScores
            // 
            this.LstScores.FormattingEnabled = true;
            this.LstScores.Location = new System.Drawing.Point(165, 52);
            this.LstScores.Name = "LstScores";
            this.LstScores.Size = new System.Drawing.Size(379, 264);
            this.LstScores.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(35, 300);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(85, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Scores";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 335);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.LstScores);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblScores);
            this.Name = "FrmScores";
            this.Text = "HIGHSCORES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox LstScores;
        private System.Windows.Forms.Button btnShow;

    }
}