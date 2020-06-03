namespace FrmIntro
{
    partial class FrmResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResults));
            this.PicPlayLight = new System.Windows.Forms.PictureBox();
            this.PicPlayDark = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblPointsTitle = new System.Windows.Forms.Label();
            this.LblTimeTitle = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblPoints = new System.Windows.Forms.Label();
            this.LblTell = new System.Windows.Forms.Label();
            this.LblTellTwo = new System.Windows.Forms.Label();
            this.PicExitLight = new System.Windows.Forms.PictureBox();
            this.PicExitDark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExitLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExitDark)).BeginInit();
            this.SuspendLayout();
            // 
            // PicPlayLight
            // 
            this.PicPlayLight.ErrorImage = null;
            this.PicPlayLight.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayLight.Image")));
            this.PicPlayLight.Location = new System.Drawing.Point(15, 177);
            this.PicPlayLight.Name = "PicPlayLight";
            this.PicPlayLight.Size = new System.Drawing.Size(128, 56);
            this.PicPlayLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayLight.TabIndex = 16;
            this.PicPlayLight.TabStop = false;
            this.PicPlayLight.Visible = false;
            this.PicPlayLight.MouseLeave += new System.EventHandler(this.PicPlayLight_MouseLeave);
            this.PicPlayLight.Click += new System.EventHandler(this.PicPlayLight_Click);
            // 
            // PicPlayDark
            // 
            this.PicPlayDark.ErrorImage = null;
            this.PicPlayDark.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayDark.Image")));
            this.PicPlayDark.Location = new System.Drawing.Point(15, 177);
            this.PicPlayDark.Name = "PicPlayDark";
            this.PicPlayDark.Size = new System.Drawing.Size(128, 56);
            this.PicPlayDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayDark.TabIndex = 15;
            this.PicPlayDark.TabStop = false;
            this.PicPlayDark.Click += new System.EventHandler(this.PicPlayDark_Click);
            this.PicPlayDark.MouseHover += new System.EventHandler(this.PicPlayDark_MouseHover);
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(8, 10);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(452, 44);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Congratulations!";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblPointsTitle
            // 
            this.LblPointsTitle.AutoSize = true;
            this.LblPointsTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPointsTitle.Location = new System.Drawing.Point(174, 87);
            this.LblPointsTitle.Name = "LblPointsTitle";
            this.LblPointsTitle.Size = new System.Drawing.Size(51, 16);
            this.LblPointsTitle.TabIndex = 17;
            this.LblPointsTitle.Text = "Points:";
            // 
            // LblTimeTitle
            // 
            this.LblTimeTitle.AutoSize = true;
            this.LblTimeTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeTitle.Location = new System.Drawing.Point(174, 144);
            this.LblTimeTitle.Name = "LblTimeTitle";
            this.LblTimeTitle.Size = new System.Drawing.Size(44, 16);
            this.LblTimeTitle.TabIndex = 18;
            this.LblTimeTitle.Text = "Time:";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(231, 144);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(0, 16);
            this.LblTime.TabIndex = 20;
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoints.Location = new System.Drawing.Point(231, 87);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(0, 16);
            this.LblPoints.TabIndex = 19;
            // 
            // LblTell
            // 
            this.LblTell.AutoSize = true;
            this.LblTell.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTell.Location = new System.Drawing.Point(174, 69);
            this.LblTell.Name = "LblTell";
            this.LblTell.Size = new System.Drawing.Size(101, 14);
            this.LblTell.TabIndex = 21;
            this.LblTell.Text = "You finished with...";
            // 
            // LblTellTwo
            // 
            this.LblTellTwo.AutoSize = true;
            this.LblTellTwo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTellTwo.Location = new System.Drawing.Point(174, 125);
            this.LblTellTwo.Name = "LblTellTwo";
            this.LblTellTwo.Size = new System.Drawing.Size(45, 14);
            this.LblTellTwo.TabIndex = 22;
            this.LblTellTwo.Text = "Within...";
            // 
            // PicExitLight
            // 
            this.PicExitLight.ErrorImage = null;
            this.PicExitLight.Image = ((System.Drawing.Image)(resources.GetObject("PicExitLight.Image")));
            this.PicExitLight.Location = new System.Drawing.Point(329, 177);
            this.PicExitLight.Name = "PicExitLight";
            this.PicExitLight.Size = new System.Drawing.Size(128, 56);
            this.PicExitLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicExitLight.TabIndex = 24;
            this.PicExitLight.TabStop = false;
            this.PicExitLight.Visible = false;
            this.PicExitLight.MouseLeave += new System.EventHandler(this.PicExitLight_MouseLeave);
            this.PicExitLight.Click += new System.EventHandler(this.PicExitLight_Click);
            // 
            // PicExitDark
            // 
            this.PicExitDark.ErrorImage = null;
            this.PicExitDark.Image = ((System.Drawing.Image)(resources.GetObject("PicExitDark.Image")));
            this.PicExitDark.Location = new System.Drawing.Point(329, 177);
            this.PicExitDark.Name = "PicExitDark";
            this.PicExitDark.Size = new System.Drawing.Size(128, 56);
            this.PicExitDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicExitDark.TabIndex = 23;
            this.PicExitDark.TabStop = false;
            this.PicExitDark.Click += new System.EventHandler(this.PicExitDark_Click);
            this.PicExitDark.MouseHover += new System.EventHandler(this.PicExitDark_MouseHover);
            // 
            // FrmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 245);
            this.Controls.Add(this.PicExitLight);
            this.Controls.Add(this.PicExitDark);
            this.Controls.Add(this.LblTellTwo);
            this.Controls.Add(this.LblTell);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.LblTimeTitle);
            this.Controls.Add(this.LblPointsTitle);
            this.Controls.Add(this.PicPlayLight);
            this.Controls.Add(this.PicPlayDark);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Results";
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExitLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExitDark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPlayLight;
        private System.Windows.Forms.PictureBox PicPlayDark;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblPointsTitle;
        private System.Windows.Forms.Label LblTimeTitle;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.Label LblTell;
        private System.Windows.Forms.Label LblTellTwo;
        private System.Windows.Forms.PictureBox PicExitLight;
        private System.Windows.Forms.PictureBox PicExitDark;
    }
}