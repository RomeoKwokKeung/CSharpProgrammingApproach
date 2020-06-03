namespace FrmIntro
{
    partial class FrmHow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHow));
            this.PicPlayLight = new System.Windows.Forms.PictureBox();
            this.PicPlayDark = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblSteps = new System.Windows.Forms.Label();
            this.LblSteps2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayDark)).BeginInit();
            this.SuspendLayout();
            // 
            // PicPlayLight
            // 
            this.PicPlayLight.ErrorImage = null;
            this.PicPlayLight.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayLight.Image")));
            this.PicPlayLight.Location = new System.Drawing.Point(171, 233);
            this.PicPlayLight.Name = "PicPlayLight";
            this.PicPlayLight.Size = new System.Drawing.Size(128, 56);
            this.PicPlayLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayLight.TabIndex = 11;
            this.PicPlayLight.TabStop = false;
            this.PicPlayLight.Visible = false;
            this.PicPlayLight.MouseLeave += new System.EventHandler(this.PicPlayLight_MouseLeave);
            this.PicPlayLight.Click += new System.EventHandler(this.PicPlayLight_Click);
            // 
            // PicPlayDark
            // 
            this.PicPlayDark.ErrorImage = null;
            this.PicPlayDark.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayDark.Image")));
            this.PicPlayDark.Location = new System.Drawing.Point(171, 233);
            this.PicPlayDark.Name = "PicPlayDark";
            this.PicPlayDark.Size = new System.Drawing.Size(128, 56);
            this.PicPlayDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayDark.TabIndex = 10;
            this.PicPlayDark.TabStop = false;
            this.PicPlayDark.Click += new System.EventHandler(this.PicPlayDark_Click);
            this.PicPlayDark.MouseHover += new System.EventHandler(this.PicPlayDark_MouseHover);
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(8, 11);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(452, 44);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "How To Play";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSteps
            // 
            this.LblSteps.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSteps.Location = new System.Drawing.Point(13, 83);
            this.LblSteps.Name = "LblSteps";
            this.LblSteps.Size = new System.Drawing.Size(443, 48);
            this.LblSteps.TabIndex = 12;
            this.LblSteps.Text = "Using the left and right arrow keys, move the submarine to different locations in" +
                " order to drop torpedos onto the swimming fish below. To drop a torpedo simply h" +
                "it the space bar.";
            // 
            // LblSteps2
            // 
            this.LblSteps2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSteps2.Location = new System.Drawing.Point(12, 135);
            this.LblSteps2.Name = "LblSteps2";
            this.LblSteps2.Size = new System.Drawing.Size(443, 48);
            this.LblSteps2.TabIndex = 13;
            this.LblSteps2.Text = resources.GetString("LblSteps2.Text");
            // 
            // FrmHow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 298);
            this.Controls.Add(this.LblSteps2);
            this.Controls.Add(this.LblSteps);
            this.Controls.Add(this.PicPlayLight);
            this.Controls.Add(this.PicPlayDark);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How To Play";
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayDark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPlayLight;
        private System.Windows.Forms.PictureBox PicPlayDark;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSteps;
        private System.Windows.Forms.Label LblSteps2;
    }
}