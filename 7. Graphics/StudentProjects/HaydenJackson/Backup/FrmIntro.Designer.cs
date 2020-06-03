namespace FrmIntro
{
    partial class FrmIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntro));
            this.LblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicHowDark = new System.Windows.Forms.PictureBox();
            this.PicHowLight = new System.Windows.Forms.PictureBox();
            this.PicPlayLight = new System.Windows.Forms.PictureBox();
            this.PicPlayDark = new System.Windows.Forms.PictureBox();
            this.LblAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicHowDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayDark)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(9, 10);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(452, 44);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Fish Bomber";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "By Hayden Jackson";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PicHowDark
            // 
            this.PicHowDark.ErrorImage = null;
            this.PicHowDark.Image = ((System.Drawing.Image)(resources.GetObject("PicHowDark.Image")));
            this.PicHowDark.Location = new System.Drawing.Point(16, 230);
            this.PicHowDark.Name = "PicHowDark";
            this.PicHowDark.Size = new System.Drawing.Size(128, 56);
            this.PicHowDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicHowDark.TabIndex = 2;
            this.PicHowDark.TabStop = false;
            this.PicHowDark.Click += new System.EventHandler(this.PicHowDark_Click);
            this.PicHowDark.MouseHover += new System.EventHandler(this.PicHowDark_MouseHover);
            // 
            // PicHowLight
            // 
            this.PicHowLight.ErrorImage = null;
            this.PicHowLight.Image = ((System.Drawing.Image)(resources.GetObject("PicHowLight.Image")));
            this.PicHowLight.Location = new System.Drawing.Point(16, 230);
            this.PicHowLight.Name = "PicHowLight";
            this.PicHowLight.Size = new System.Drawing.Size(128, 56);
            this.PicHowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicHowLight.TabIndex = 3;
            this.PicHowLight.TabStop = false;
            this.PicHowLight.Visible = false;
            this.PicHowLight.MouseLeave += new System.EventHandler(this.PicHowLight_MouseLeave);
            this.PicHowLight.Click += new System.EventHandler(this.PicHowLight_Click);
            // 
            // PicPlayLight
            // 
            this.PicPlayLight.ErrorImage = null;
            this.PicPlayLight.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayLight.Image")));
            this.PicPlayLight.Location = new System.Drawing.Point(333, 230);
            this.PicPlayLight.Name = "PicPlayLight";
            this.PicPlayLight.Size = new System.Drawing.Size(128, 56);
            this.PicPlayLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayLight.TabIndex = 5;
            this.PicPlayLight.TabStop = false;
            this.PicPlayLight.Visible = false;
            this.PicPlayLight.MouseLeave += new System.EventHandler(this.PicPlayLight_MouseLeave);
            this.PicPlayLight.Click += new System.EventHandler(this.PicPlayLight_Click);
            // 
            // PicPlayDark
            // 
            this.PicPlayDark.ErrorImage = null;
            this.PicPlayDark.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayDark.Image")));
            this.PicPlayDark.Location = new System.Drawing.Point(333, 230);
            this.PicPlayDark.Name = "PicPlayDark";
            this.PicPlayDark.Size = new System.Drawing.Size(128, 56);
            this.PicPlayDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayDark.TabIndex = 4;
            this.PicPlayDark.TabStop = false;
            this.PicPlayDark.Click += new System.EventHandler(this.PicPlayDark_Click);
            this.PicPlayDark.MouseHover += new System.EventHandler(this.PicPlayDark_MouseHover);
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAd.Location = new System.Drawing.Point(121, 137);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(233, 23);
            this.LblAd.TabIndex = 6;
            this.LblAd.Text = "Be the quickest to 25 fish!";
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 298);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.PicPlayLight);
            this.Controls.Add(this.PicPlayDark);
            this.Controls.Add(this.PicHowLight);
            this.Controls.Add(this.PicHowDark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fish Bomber";
            ((System.ComponentModel.ISupportInitialize)(this.PicHowDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayDark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicHowDark;
        private System.Windows.Forms.PictureBox PicHowLight;
        private System.Windows.Forms.PictureBox PicPlayLight;
        private System.Windows.Forms.PictureBox PicPlayDark;
        private System.Windows.Forms.Label LblAd;
    }
}

