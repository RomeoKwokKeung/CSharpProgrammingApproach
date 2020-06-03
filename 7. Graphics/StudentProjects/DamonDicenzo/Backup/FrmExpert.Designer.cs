namespace GuitarHeroClone
{
    partial class FrmExpert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpert));
            this.TimCountdown = new System.Windows.Forms.Timer(this.components);
            this.TimGNote = new System.Windows.Forms.Timer(this.components);
            this.LblHits = new System.Windows.Forms.Label();
            this.LblHitsTitle = new System.Windows.Forms.Label();
            this.LblScoreTitle = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.TimRNote = new System.Windows.Forms.Timer(this.components);
            this.TimYNote = new System.Windows.Forms.Timer(this.components);
            this.TimBNote = new System.Windows.Forms.Timer(this.components);
            this.TimONote = new System.Windows.Forms.Timer(this.components);
            this.TimSong = new System.Windows.Forms.Timer(this.components);
            this.WmpSong = new AxWMPLib.AxWindowsMediaPlayer();
            this.TimInvalidate = new System.Windows.Forms.Timer(this.components);
            this.PnlPaused = new System.Windows.Forms.Panel();
            this.LblChangeDifficulty = new System.Windows.Forms.Label();
            this.LblResume = new System.Windows.Forms.Label();
            this.LblQuit = new System.Windows.Forms.Label();
            this.LblPaused = new System.Windows.Forms.Label();
            this.LblToPause = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WmpSong)).BeginInit();
            this.PnlPaused.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimCountdown
            // 
            this.TimCountdown.Enabled = true;
            this.TimCountdown.Interval = 1000;
            this.TimCountdown.Tick += new System.EventHandler(this.TimCountdown_Tick);
            // 
            // TimGNote
            // 
            this.TimGNote.Tick += new System.EventHandler(this.TimGNote_Tick);
            // 
            // LblHits
            // 
            this.LblHits.BackColor = System.Drawing.Color.Transparent;
            this.LblHits.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHits.ForeColor = System.Drawing.Color.White;
            this.LblHits.Location = new System.Drawing.Point(111, 82);
            this.LblHits.Name = "LblHits";
            this.LblHits.Size = new System.Drawing.Size(266, 29);
            this.LblHits.TabIndex = 0;
            this.LblHits.Text = "99999";
            // 
            // LblHitsTitle
            // 
            this.LblHitsTitle.AutoSize = true;
            this.LblHitsTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblHitsTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHitsTitle.ForeColor = System.Drawing.Color.White;
            this.LblHitsTitle.Location = new System.Drawing.Point(111, 53);
            this.LblHitsTitle.Name = "LblHitsTitle";
            this.LblHitsTitle.Size = new System.Drawing.Size(60, 29);
            this.LblHitsTitle.TabIndex = 1;
            this.LblHitsTitle.Text = "Hits";
            // 
            // LblScoreTitle
            // 
            this.LblScoreTitle.AutoSize = true;
            this.LblScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblScoreTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreTitle.ForeColor = System.Drawing.Color.White;
            this.LblScoreTitle.Location = new System.Drawing.Point(622, 53);
            this.LblScoreTitle.Name = "LblScoreTitle";
            this.LblScoreTitle.Size = new System.Drawing.Size(80, 29);
            this.LblScoreTitle.TabIndex = 3;
            this.LblScoreTitle.Text = "Score";
            // 
            // LblScore
            // 
            this.LblScore.BackColor = System.Drawing.Color.Transparent;
            this.LblScore.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.ForeColor = System.Drawing.Color.White;
            this.LblScore.Location = new System.Drawing.Point(477, 82);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(225, 29);
            this.LblScore.TabIndex = 2;
            this.LblScore.Text = "99999";
            this.LblScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TimRNote
            // 
            this.TimRNote.Tick += new System.EventHandler(this.TimRNote_Tick);
            // 
            // TimYNote
            // 
            this.TimYNote.Tick += new System.EventHandler(this.TimYNote_Tick);
            // 
            // TimBNote
            // 
            this.TimBNote.Tick += new System.EventHandler(this.TimBNote_Tick);
            // 
            // TimONote
            // 
            this.TimONote.Tick += new System.EventHandler(this.TimONote_Tick);
            // 
            // TimSong
            // 
            this.TimSong.Interval = 500;
            this.TimSong.Tick += new System.EventHandler(this.TimSong_Tick);
            // 
            // WmpSong
            // 
            this.WmpSong.Enabled = true;
            this.WmpSong.Location = new System.Drawing.Point(12, 522);
            this.WmpSong.Name = "WmpSong";
            this.WmpSong.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpSong.OcxState")));
            this.WmpSong.Size = new System.Drawing.Size(67, 28);
            this.WmpSong.TabIndex = 4;
            this.WmpSong.Visible = false;
            // 
            // TimInvalidate
            // 
            this.TimInvalidate.Tick += new System.EventHandler(this.TimInvalidate_Tick);
            // 
            // PnlPaused
            // 
            this.PnlPaused.BackColor = System.Drawing.Color.Silver;
            this.PnlPaused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPaused.Controls.Add(this.LblChangeDifficulty);
            this.PnlPaused.Controls.Add(this.LblResume);
            this.PnlPaused.Controls.Add(this.LblQuit);
            this.PnlPaused.Controls.Add(this.LblPaused);
            this.PnlPaused.Location = new System.Drawing.Point(242, 157);
            this.PnlPaused.Name = "PnlPaused";
            this.PnlPaused.Size = new System.Drawing.Size(338, 223);
            this.PnlPaused.TabIndex = 5;
            this.PnlPaused.Visible = false;
            // 
            // LblChangeDifficulty
            // 
            this.LblChangeDifficulty.AutoSize = true;
            this.LblChangeDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblChangeDifficulty.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangeDifficulty.Location = new System.Drawing.Point(23, 118);
            this.LblChangeDifficulty.Name = "LblChangeDifficulty";
            this.LblChangeDifficulty.Size = new System.Drawing.Size(191, 25);
            this.LblChangeDifficulty.TabIndex = 3;
            this.LblChangeDifficulty.Text = "Change Difficulty";
            this.LblChangeDifficulty.Visible = false;
            this.LblChangeDifficulty.Click += new System.EventHandler(this.LblChangeDifficulty_Click);
            // 
            // LblResume
            // 
            this.LblResume.AutoSize = true;
            this.LblResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblResume.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResume.Location = new System.Drawing.Point(23, 163);
            this.LblResume.Name = "LblResume";
            this.LblResume.Size = new System.Drawing.Size(162, 25);
            this.LblResume.TabIndex = 2;
            this.LblResume.Text = "Resume Game";
            this.LblResume.Visible = false;
            this.LblResume.Click += new System.EventHandler(this.LblResume_Click);
            // 
            // LblQuit
            // 
            this.LblQuit.AutoSize = true;
            this.LblQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblQuit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuit.Location = new System.Drawing.Point(23, 74);
            this.LblQuit.Name = "LblQuit";
            this.LblQuit.Size = new System.Drawing.Size(139, 25);
            this.LblQuit.TabIndex = 1;
            this.LblQuit.Text = "Quit Playing";
            this.LblQuit.Visible = false;
            this.LblQuit.Click += new System.EventHandler(this.LblQuit_Click);
            // 
            // LblPaused
            // 
            this.LblPaused.AutoSize = true;
            this.LblPaused.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaused.ForeColor = System.Drawing.Color.Maroon;
            this.LblPaused.Location = new System.Drawing.Point(104, 13);
            this.LblPaused.Name = "LblPaused";
            this.LblPaused.Size = new System.Drawing.Size(133, 35);
            this.LblPaused.TabIndex = 0;
            this.LblPaused.Text = "PAUSED";
            this.LblPaused.Visible = false;
            // 
            // LblToPause
            // 
            this.LblToPause.AutoSize = true;
            this.LblToPause.BackColor = System.Drawing.Color.Transparent;
            this.LblToPause.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToPause.ForeColor = System.Drawing.Color.White;
            this.LblToPause.Location = new System.Drawing.Point(676, 534);
            this.LblToPause.Name = "LblToPause";
            this.LblToPause.Size = new System.Drawing.Size(119, 16);
            this.LblToPause.TabIndex = 19;
            this.LblToPause.Text = "Press ESC to Pause";
            // 
            // FrmExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 562);
            this.Controls.Add(this.LblToPause);
            this.Controls.Add(this.PnlPaused);
            this.Controls.Add(this.WmpSong);
            this.Controls.Add(this.LblScoreTitle);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblHitsTitle);
            this.Controls.Add(this.LblHits);
            this.MaximizeBox = false;
            this.Name = "FrmExpert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero of Guitar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmExpert_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmExpert_KeyDown);
            this.Load += new System.EventHandler(this.FrmExpert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WmpSong)).EndInit();
            this.PnlPaused.ResumeLayout(false);
            this.PnlPaused.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimCountdown;
        private System.Windows.Forms.Timer TimGNote;
        private System.Windows.Forms.Label LblHits;
        private System.Windows.Forms.Label LblHitsTitle;
        private System.Windows.Forms.Label LblScoreTitle;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Timer TimRNote;
        private System.Windows.Forms.Timer TimYNote;
        private System.Windows.Forms.Timer TimBNote;
        private System.Windows.Forms.Timer TimONote;
        private System.Windows.Forms.Timer TimSong;
        private AxWMPLib.AxWindowsMediaPlayer WmpSong;
        private System.Windows.Forms.Timer TimInvalidate;
        private System.Windows.Forms.Panel PnlPaused;
        private System.Windows.Forms.Label LblPaused;
        private System.Windows.Forms.Label LblChangeDifficulty;
        private System.Windows.Forms.Label LblResume;
        private System.Windows.Forms.Label LblQuit;
        private System.Windows.Forms.Label LblToPause;
    }
}