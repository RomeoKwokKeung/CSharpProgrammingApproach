namespace FinalGameAssignment
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.BarPower = new System.Windows.Forms.ProgressBar();
            this.BarHitpoints = new System.Windows.Forms.ProgressBar();
            this.LblHitpoints = new System.Windows.Forms.Label();
            this.LblPower = new System.Windows.Forms.Label();
            this.TmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.BarEnemy1 = new System.Windows.Forms.ProgressBar();
            this.LblEnemy = new System.Windows.Forms.Label();
            this.TmrImages = new System.Windows.Forms.Timer(this.components);
            this.LblLevel = new System.Windows.Forms.Label();
            this.BarEnemy2 = new System.Windows.Forms.ProgressBar();
            this.BarEnemy3 = new System.Windows.Forms.ProgressBar();
            this.WmpBgm = new AxWMPLib.AxWindowsMediaPlayer();
            this.TmrBoss = new System.Windows.Forms.Timer(this.components);
            this.TmrHeal = new System.Windows.Forms.Timer(this.components);
            this.WmpEffects = new AxWMPLib.AxWindowsMediaPlayer();
            this.WmpPlayerEffects = new AxWMPLib.AxWindowsMediaPlayer();
            this.TmrBossMove = new System.Windows.Forms.Timer(this.components);
            this.TmrMusic = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WmpBgm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpEffects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpPlayerEffects)).BeginInit();
            this.SuspendLayout();
            // 
            // BarPower
            // 
            this.BarPower.BackColor = System.Drawing.Color.Black;
            this.BarPower.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BarPower.Location = new System.Drawing.Point(436, 403);
            this.BarPower.Maximum = 20;
            this.BarPower.Name = "BarPower";
            this.BarPower.Size = new System.Drawing.Size(138, 22);
            this.BarPower.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarPower.TabIndex = 0;
            this.BarPower.Value = 20;
            // 
            // BarHitpoints
            // 
            this.BarHitpoints.BackColor = System.Drawing.Color.Black;
            this.BarHitpoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BarHitpoints.Location = new System.Drawing.Point(12, 400);
            this.BarHitpoints.Maximum = 50;
            this.BarHitpoints.Name = "BarHitpoints";
            this.BarHitpoints.Size = new System.Drawing.Size(138, 22);
            this.BarHitpoints.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarHitpoints.TabIndex = 1;
            this.BarHitpoints.Value = 50;
            // 
            // LblHitpoints
            // 
            this.LblHitpoints.AutoSize = true;
            this.LblHitpoints.BackColor = System.Drawing.Color.Transparent;
            this.LblHitpoints.Font = new System.Drawing.Font("MS Mincho", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHitpoints.ForeColor = System.Drawing.Color.Black;
            this.LblHitpoints.Location = new System.Drawing.Point(41, 384);
            this.LblHitpoints.Name = "LblHitpoints";
            this.LblHitpoints.Size = new System.Drawing.Size(79, 13);
            this.LblHitpoints.TabIndex = 2;
            this.LblHitpoints.Text = "Hitpoints";
            // 
            // LblPower
            // 
            this.LblPower.AutoSize = true;
            this.LblPower.BackColor = System.Drawing.Color.Transparent;
            this.LblPower.Font = new System.Drawing.Font("MS Mincho", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPower.ForeColor = System.Drawing.Color.Black;
            this.LblPower.Location = new System.Drawing.Point(481, 387);
            this.LblPower.Name = "LblPower";
            this.LblPower.Size = new System.Drawing.Size(47, 13);
            this.LblPower.TabIndex = 3;
            this.LblPower.Text = "Power";
            // 
            // TmrUpdate
            // 
            this.TmrUpdate.Interval = 250;
            this.TmrUpdate.Tick += new System.EventHandler(this.TmrUpdate_Tick);
            // 
            // BarEnemy1
            // 
            this.BarEnemy1.BackColor = System.Drawing.Color.Black;
            this.BarEnemy1.ForeColor = System.Drawing.Color.Red;
            this.BarEnemy1.Location = new System.Drawing.Point(152, 27);
            this.BarEnemy1.Maximum = 50;
            this.BarEnemy1.Name = "BarEnemy1";
            this.BarEnemy1.Size = new System.Drawing.Size(289, 25);
            this.BarEnemy1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarEnemy1.TabIndex = 4;
            this.BarEnemy1.Value = 50;
            this.BarEnemy1.Visible = false;
            // 
            // LblEnemy
            // 
            this.LblEnemy.AutoSize = true;
            this.LblEnemy.BackColor = System.Drawing.Color.Transparent;
            this.LblEnemy.Font = new System.Drawing.Font("MS Mincho", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnemy.ForeColor = System.Drawing.Color.Black;
            this.LblEnemy.Location = new System.Drawing.Point(218, 9);
            this.LblEnemy.Name = "LblEnemy";
            this.LblEnemy.Size = new System.Drawing.Size(143, 13);
            this.LblEnemy.TabIndex = 5;
            this.LblEnemy.Text = "Enemy\'s Hitpoints";
            // 
            // TmrImages
            // 
            this.TmrImages.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.BackColor = System.Drawing.Color.Transparent;
            this.LblLevel.Font = new System.Drawing.Font("MS Mincho", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLevel.Location = new System.Drawing.Point(255, 403);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(86, 19);
            this.LblLevel.TabIndex = 6;
            this.LblLevel.Text = "Level 1";
            // 
            // BarEnemy2
            // 
            this.BarEnemy2.BackColor = System.Drawing.Color.Black;
            this.BarEnemy2.ForeColor = System.Drawing.Color.Red;
            this.BarEnemy2.Location = new System.Drawing.Point(76, 27);
            this.BarEnemy2.Name = "BarEnemy2";
            this.BarEnemy2.Size = new System.Drawing.Size(431, 25);
            this.BarEnemy2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarEnemy2.TabIndex = 7;
            this.BarEnemy2.Value = 100;
            this.BarEnemy2.Visible = false;
            // 
            // BarEnemy3
            // 
            this.BarEnemy3.BackColor = System.Drawing.Color.Black;
            this.BarEnemy3.ForeColor = System.Drawing.Color.Red;
            this.BarEnemy3.Location = new System.Drawing.Point(12, 26);
            this.BarEnemy3.Maximum = 200;
            this.BarEnemy3.Name = "BarEnemy3";
            this.BarEnemy3.Size = new System.Drawing.Size(562, 26);
            this.BarEnemy3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarEnemy3.TabIndex = 8;
            this.BarEnemy3.Value = 200;
            this.BarEnemy3.Visible = false;
            // 
            // WmpBgm
            // 
            this.WmpBgm.Enabled = true;
            this.WmpBgm.Location = new System.Drawing.Point(174, 399);
            this.WmpBgm.Name = "WmpBgm";
            this.WmpBgm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpBgm.OcxState")));
            this.WmpBgm.Size = new System.Drawing.Size(75, 23);
            this.WmpBgm.TabIndex = 9;
            this.WmpBgm.Visible = false;
            // 
            // TmrBoss
            // 
            this.TmrBoss.Interval = 4000;
            this.TmrBoss.Tick += new System.EventHandler(this.TmrBoss_Tick);
            // 
            // TmrHeal
            // 
            this.TmrHeal.Interval = 1000;
            this.TmrHeal.Tick += new System.EventHandler(this.TmrHeal_Tick);
            // 
            // WmpEffects
            // 
            this.WmpEffects.Enabled = true;
            this.WmpEffects.Location = new System.Drawing.Point(355, 399);
            this.WmpEffects.Name = "WmpEffects";
            this.WmpEffects.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpEffects.OcxState")));
            this.WmpEffects.Size = new System.Drawing.Size(75, 23);
            this.WmpEffects.TabIndex = 10;
            this.WmpEffects.Visible = false;
            // 
            // WmpPlayerEffects
            // 
            this.WmpPlayerEffects.Enabled = true;
            this.WmpPlayerEffects.Location = new System.Drawing.Point(259, 364);
            this.WmpPlayerEffects.Name = "WmpPlayerEffects";
            this.WmpPlayerEffects.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpPlayerEffects.OcxState")));
            this.WmpPlayerEffects.Size = new System.Drawing.Size(75, 23);
            this.WmpPlayerEffects.TabIndex = 11;
            this.WmpPlayerEffects.Visible = false;
            // 
            // TmrBossMove
            // 
            this.TmrBossMove.Interval = 2500;
            this.TmrBossMove.Tick += new System.EventHandler(this.TmrBossMove_Tick);
            // 
            // TmrMusic
            // 
            this.TmrMusic.Interval = 90000;
            this.TmrMusic.Tick += new System.EventHandler(this.TmrMusic_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 437);
            this.Controls.Add(this.WmpPlayerEffects);
            this.Controls.Add(this.WmpEffects);
            this.Controls.Add(this.WmpBgm);
            this.Controls.Add(this.BarEnemy1);
            this.Controls.Add(this.BarEnemy2);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.LblEnemy);
            this.Controls.Add(this.LblPower);
            this.Controls.Add(this.LblHitpoints);
            this.Controls.Add(this.BarHitpoints);
            this.Controls.Add(this.BarPower);
            this.Controls.Add(this.BarEnemy3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digimon Adventure";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGame_Paint);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WmpBgm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpEffects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpPlayerEffects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarPower;
        private System.Windows.Forms.ProgressBar BarHitpoints;
        private System.Windows.Forms.Label LblHitpoints;
        private System.Windows.Forms.Label LblPower;
        private System.Windows.Forms.Timer TmrUpdate;
        private System.Windows.Forms.ProgressBar BarEnemy1;
        private System.Windows.Forms.Label LblEnemy;
        private System.Windows.Forms.Timer TmrImages;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.ProgressBar BarEnemy2;
        private System.Windows.Forms.ProgressBar BarEnemy3;
        private AxWMPLib.AxWindowsMediaPlayer WmpBgm;
        private System.Windows.Forms.Timer TmrBoss;
        private System.Windows.Forms.Timer TmrHeal;
        private AxWMPLib.AxWindowsMediaPlayer WmpEffects;
        private AxWMPLib.AxWindowsMediaPlayer WmpPlayerEffects;
        private System.Windows.Forms.Timer TmrBossMove;
        private System.Windows.Forms.Timer TmrMusic;
    }
}

