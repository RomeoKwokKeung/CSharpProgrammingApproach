namespace DrawImageAnimationIntro
{
    partial class FrmDrawImage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDrawImage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicMan = new System.Windows.Forms.PictureBox();
            this.BtnBegin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicBallTransparent = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.PicMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBallTransparent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(26, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 424);
            this.panel1.TabIndex = 0;
            // 
            // PicMan
            // 
            this.PicMan.Image = global::DrawImageAnimationIntro.Properties.Resources.tdribble1;
            this.PicMan.Location = new System.Drawing.Point(391, 123);
            this.PicMan.Name = "PicMan";
            this.PicMan.Size = new System.Drawing.Size(55, 61);
            this.PicMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicMan.TabIndex = 0;
            this.PicMan.TabStop = false;
            this.PicMan.Visible = false;
            // 
            // BtnBegin
            // 
            this.BtnBegin.Location = new System.Drawing.Point(374, 80);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(84, 25);
            this.BtnBegin.TabIndex = 2;
            this.BtnBegin.Text = "Start/Stop";
            this.BtnBegin.UseVisualStyleBackColor = true;
            this.BtnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PicBallTransparent
            // 
            this.PicBallTransparent.Image = global::DrawImageAnimationIntro.Properties.Resources.trball;
            this.PicBallTransparent.Location = new System.Drawing.Point(418, 18);
            this.PicBallTransparent.Name = "PicBallTransparent";
            this.PicBallTransparent.Size = new System.Drawing.Size(40, 40);
            this.PicBallTransparent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBallTransparent.TabIndex = 3;
            this.PicBallTransparent.TabStop = false;
            this.PicBallTransparent.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(396, 370);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(61, 44);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // FrmDrawImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 454);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PicMan);
            this.Controls.Add(this.PicBallTransparent);
            this.Controls.Add(this.BtnBegin);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmDrawImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collision Detection";
            this.Load += new System.EventHandler(this.FrmDrawImage_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDrawImage_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDrawImage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBallTransparent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PicBallTransparent;
        private System.Windows.Forms.PictureBox PicMan;
        private System.Windows.Forms.Timer timer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

