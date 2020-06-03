namespace Animation1
{
    partial class FrmAnimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimation));
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timobstacle = new System.Windows.Forms.Timer(this.components);
            this.TimBus = new System.Windows.Forms.Timer(this.components);
            this.TimBike = new System.Windows.Forms.Timer(this.components);
            this.TimTruck = new System.Windows.Forms.Timer(this.components);
            this.PicStats = new System.Windows.Forms.PictureBox();
            this.LblTitleScore = new System.Windows.Forms.Label();
            this.LblTitleLives = new System.Windows.Forms.Label();
            this.LblTitleHealth = new System.Windows.Forms.Label();
            this.LbltitleTL = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.LblHealth = new System.Windows.Forms.Label();
            this.LblTimeLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStats)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 128);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(108, 27);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 632);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(67, 28);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // timobstacle
            // 
            this.timobstacle.Interval = 2000;
            this.timobstacle.Tick += new System.EventHandler(this.timobstacle_Tick);
            // 
            // TimBus
            // 
            this.TimBus.Tick += new System.EventHandler(this.TimBus_Tick);
            // 
            // TimBike
            // 
            this.TimBike.Tick += new System.EventHandler(this.TimBike_Tick);
            // 
            // TimTruck
            // 
            this.TimTruck.Tick += new System.EventHandler(this.TimTruck_Tick);
            // 
            // PicStats
            // 
            this.PicStats.Image = global::ProStreetRacer.Properties.Resources.stats;
            this.PicStats.Location = new System.Drawing.Point(10, 12);
            this.PicStats.Name = "PicStats";
            this.PicStats.Size = new System.Drawing.Size(110, 110);
            this.PicStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicStats.TabIndex = 2;
            this.PicStats.TabStop = false;
            // 
            // LblTitleScore
            // 
            this.LblTitleScore.AutoSize = true;
            this.LblTitleScore.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblTitleScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTitleScore.Location = new System.Drawing.Point(31, 41);
            this.LblTitleScore.Name = "LblTitleScore";
            this.LblTitleScore.Size = new System.Drawing.Size(38, 13);
            this.LblTitleScore.TabIndex = 3;
            this.LblTitleScore.Text = "Score:";
            // 
            // LblTitleLives
            // 
            this.LblTitleLives.AutoSize = true;
            this.LblTitleLives.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblTitleLives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTitleLives.Location = new System.Drawing.Point(34, 58);
            this.LblTitleLives.Name = "LblTitleLives";
            this.LblTitleLives.Size = new System.Drawing.Size(35, 13);
            this.LblTitleLives.TabIndex = 4;
            this.LblTitleLives.Text = "Lives:";
            // 
            // LblTitleHealth
            // 
            this.LblTitleHealth.AutoSize = true;
            this.LblTitleHealth.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblTitleHealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTitleHealth.Location = new System.Drawing.Point(28, 76);
            this.LblTitleHealth.Name = "LblTitleHealth";
            this.LblTitleHealth.Size = new System.Drawing.Size(41, 13);
            this.LblTitleHealth.TabIndex = 5;
            this.LblTitleHealth.Text = "Health:";
            // 
            // LbltitleTL
            // 
            this.LbltitleTL.AutoSize = true;
            this.LbltitleTL.BackColor = System.Drawing.SystemColors.ControlText;
            this.LbltitleTL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbltitleTL.Location = new System.Drawing.Point(22, 97);
            this.LbltitleTL.Name = "LbltitleTL";
            this.LbltitleTL.Size = new System.Drawing.Size(47, 13);
            this.LbltitleTL.TabIndex = 6;
            this.LbltitleTL.Text = "Timeleft:";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblScore.Location = new System.Drawing.Point(79, 41);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(19, 13);
            this.LblScore.TabIndex = 7;
            this.LblScore.Text = "00";
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblLives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblLives.Location = new System.Drawing.Point(79, 58);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(19, 13);
            this.LblLives.TabIndex = 8;
            this.LblLives.Text = "00";
            // 
            // LblHealth
            // 
            this.LblHealth.AutoSize = true;
            this.LblHealth.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblHealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblHealth.Location = new System.Drawing.Point(79, 76);
            this.LblHealth.Name = "LblHealth";
            this.LblHealth.Size = new System.Drawing.Size(19, 13);
            this.LblHealth.TabIndex = 9;
            this.LblHealth.Text = "00";
            // 
            // LblTimeLeft
            // 
            this.LblTimeLeft.AutoSize = true;
            this.LblTimeLeft.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblTimeLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTimeLeft.Location = new System.Drawing.Point(79, 97);
            this.LblTimeLeft.Name = "LblTimeLeft";
            this.LblTimeLeft.Size = new System.Drawing.Size(19, 13);
            this.LblTimeLeft.TabIndex = 10;
            this.LblTimeLeft.Text = "00";
            // 
            // FrmAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 672);
            this.Controls.Add(this.LblTimeLeft);
            this.Controls.Add(this.LblHealth);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LbltitleTL);
            this.Controls.Add(this.LblTitleHealth);
            this.Controls.Add(this.LblTitleLives);
            this.Controls.Add(this.LblTitleScore);
            this.Controls.Add(this.PicStats);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.KeyPreview = true;
            this.Name = "FrmAnimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmAnimation_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAnimation_KeyDown);
            this.Load += new System.EventHandler(this.FrmAnimation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timobstacle;
        private System.Windows.Forms.Timer TimBus;
        private System.Windows.Forms.Timer TimBike;
        private System.Windows.Forms.Timer TimTruck;
        private System.Windows.Forms.PictureBox PicStats;
        private System.Windows.Forms.Label LblTitleScore;
        private System.Windows.Forms.Label LblTitleLives;
        private System.Windows.Forms.Label LblTitleHealth;
        private System.Windows.Forms.Label LbltitleTL;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label LblHealth;
        private System.Windows.Forms.Label LblTimeLeft;
    }
}

