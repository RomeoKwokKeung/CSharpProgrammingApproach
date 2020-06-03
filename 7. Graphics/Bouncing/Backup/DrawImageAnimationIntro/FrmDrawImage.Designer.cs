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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBegin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicBallTransparent = new System.Windows.Forms.PictureBox();
            this.PicBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBallTransparent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(26, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 272);
            this.panel1.TabIndex = 0;
            // 
            // BtnBegin
            // 
            this.BtnBegin.Location = new System.Drawing.Point(221, 110);
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
            this.PicBallTransparent.Location = new System.Drawing.Point(287, 22);
            this.PicBallTransparent.Name = "PicBallTransparent";
            this.PicBallTransparent.Size = new System.Drawing.Size(40, 40);
            this.PicBallTransparent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBallTransparent.TabIndex = 3;
            this.PicBallTransparent.TabStop = false;
            this.PicBallTransparent.Visible = false;
            // 
            // PicBall
            // 
            this.PicBall.Image = global::DrawImageAnimationIntro.Properties.Resources.BALL;
            this.PicBall.Location = new System.Drawing.Point(222, 21);
            this.PicBall.Name = "PicBall";
            this.PicBall.Size = new System.Drawing.Size(40, 40);
            this.PicBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBall.TabIndex = 1;
            this.PicBall.TabStop = false;
            this.PicBall.Visible = false;
            // 
            // FrmDrawImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 310);
            this.Controls.Add(this.PicBallTransparent);
            this.Controls.Add(this.BtnBegin);
            this.Controls.Add(this.PicBall);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDrawImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawImage Animation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDrawImage_FormClosing);
            this.Load += new System.EventHandler(this.FrmDrawImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBallTransparent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBall;
        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PicBallTransparent;
    }
}

