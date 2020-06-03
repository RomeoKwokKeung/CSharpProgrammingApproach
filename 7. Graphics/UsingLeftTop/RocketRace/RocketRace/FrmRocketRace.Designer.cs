namespace RocketRace
{
    partial class FrmRocketRace
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
            this.PicRocket1 = new System.Windows.Forms.PictureBox();
            this.PicRocket2 = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicRocket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRocket2)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRocket1
            // 
            this.PicRocket1.Image = global::RocketRace.Properties.Resources.ROCKET;
            this.PicRocket1.Location = new System.Drawing.Point(169, 337);
            this.PicRocket1.Name = "PicRocket1";
            this.PicRocket1.Size = new System.Drawing.Size(36, 38);
            this.PicRocket1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRocket1.TabIndex = 0;
            this.PicRocket1.TabStop = false;
            // 
            // PicRocket2
            // 
            this.PicRocket2.Image = global::RocketRace.Properties.Resources.ROCKET;
            this.PicRocket2.Location = new System.Drawing.Point(235, 337);
            this.PicRocket2.Name = "PicRocket2";
            this.PicRocket2.Size = new System.Drawing.Size(36, 38);
            this.PicRocket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRocket2.TabIndex = 1;
            this.PicRocket2.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 337);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(89, 28);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start The Race";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(345, 337);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(89, 28);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmRocketRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 437);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PicRocket2);
            this.Controls.Add(this.PicRocket1);
            this.Name = "FrmRocketRace";
            this.Text = "Rocket Race";
            ((System.ComponentModel.ISupportInitialize)(this.PicRocket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRocket2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRocket1;
        private System.Windows.Forms.PictureBox PicRocket2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnReset;
    }
}

