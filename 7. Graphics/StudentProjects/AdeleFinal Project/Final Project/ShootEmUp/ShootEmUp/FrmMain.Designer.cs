namespace Shooter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.WMPMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStart = new System.Windows.Forms.Button();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.picHeart2 = new System.Windows.Forms.PictureBox();
            this.picHeart3 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.lblInstructions3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // WMPMusic
            // 
            this.WMPMusic.Enabled = true;
            this.WMPMusic.Location = new System.Drawing.Point(418, 206);
            this.WMPMusic.Name = "WMPMusic";
            this.WMPMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPMusic.OcxState")));
            this.WMPMusic.Size = new System.Drawing.Size(81, 34);
            this.WMPMusic.TabIndex = 0;
            this.WMPMusic.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Location = new System.Drawing.Point(408, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START/STOP";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // picHeart
            // 
            this.picHeart.Image = ((System.Drawing.Image)(resources.GetObject("picHeart.Image")));
            this.picHeart.Location = new System.Drawing.Point(408, 146);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(28, 25);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart.TabIndex = 3;
            this.picHeart.TabStop = false;
            // 
            // picHeart2
            // 
            this.picHeart2.Image = ((System.Drawing.Image)(resources.GetObject("picHeart2.Image")));
            this.picHeart2.Location = new System.Drawing.Point(442, 146);
            this.picHeart2.Name = "picHeart2";
            this.picHeart2.Size = new System.Drawing.Size(28, 25);
            this.picHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart2.TabIndex = 4;
            this.picHeart2.TabStop = false;
            // 
            // picHeart3
            // 
            this.picHeart3.Image = ((System.Drawing.Image)(resources.GetObject("picHeart3.Image")));
            this.picHeart3.Location = new System.Drawing.Point(476, 146);
            this.picHeart3.Name = "picHeart3";
            this.picHeart3.Size = new System.Drawing.Size(28, 25);
            this.picHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart3.TabIndex = 5;
            this.picHeart3.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.Color.MintCream;
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtPoints.Location = new System.Drawing.Point(409, 91);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(100, 22);
            this.txtPoints.TabIndex = 6;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPoints.Location = new System.Drawing.Point(428, 68);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(57, 20);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "Points";
            // 
            // timer4
            // 
            this.timer4.Interval = 6500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.ForeColor = System.Drawing.Color.Green;
            this.lblInstructions.Location = new System.Drawing.Point(75, 83);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(215, 13);
            this.lblInstructions.TabIndex = 8;
            this.lblInstructions.Text = "Use the A and D keys to move Jake English";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.ForeColor = System.Drawing.Color.Green;
            this.lblInstructions2.Location = new System.Drawing.Point(144, 96);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(81, 13);
            this.lblInstructions2.TabIndex = 9;
            this.lblInstructions2.Text = "Use W to shoot";
            // 
            // lblInstructions3
            // 
            this.lblInstructions3.AutoSize = true;
            this.lblInstructions3.ForeColor = System.Drawing.Color.Green;
            this.lblInstructions3.Location = new System.Drawing.Point(93, 109);
            this.lblInstructions3.Name = "lblInstructions3";
            this.lblInstructions3.Size = new System.Drawing.Size(175, 13);
            this.lblInstructions3.TabIndex = 10;
            this.lblInstructions3.Text = "Don\'t let the Imps reach the bottom!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(517, 483);
            this.Controls.Add(this.lblInstructions3);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.picHeart3);
            this.Controls.Add(this.picHeart2);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.WMPMusic);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Shoot \'Em Up!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private AxWMPLib.AxWindowsMediaPlayer WMPMusic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.PictureBox picHeart2;
        private System.Windows.Forms.PictureBox picHeart3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.Label lblInstructions3;
    }
}

