namespace Megaman
{
    partial class Mega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mega));
            this.BtnStart = new System.Windows.Forms.Button();
            this.TimRun = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.LstDis = new System.Windows.Forms.ListBox();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level1IceLandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level2RockyCanyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level3MagmaDragoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProL = new System.Windows.Forms.ProgressBar();
            this.BtnLvl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Yellow;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(217, 349);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(85, 37);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TimRun
            // 
            this.TimRun.Interval = 50;
            this.TimRun.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(124, 349);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(71, 37);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // LstDis
            // 
            this.LstDis.FormattingEnabled = true;
            this.LstDis.Location = new System.Drawing.Point(25, 98);
            this.LstDis.Name = "LstDis";
            this.LstDis.Size = new System.Drawing.Size(514, 173);
            this.LstDis.TabIndex = 15;
            this.LstDis.Visible = false;
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // levelsToolStripMenuItem
            // 
            this.levelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level1IceLandToolStripMenuItem,
            this.level2RockyCanyonToolStripMenuItem,
            this.level3MagmaDragoonToolStripMenuItem});
            this.levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            this.levelsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.levelsToolStripMenuItem.Text = "Levels";
            // 
            // level1IceLandToolStripMenuItem
            // 
            this.level1IceLandToolStripMenuItem.Name = "level1IceLandToolStripMenuItem";
            this.level1IceLandToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.level1IceLandToolStripMenuItem.Text = "Level 1 - Ice Land";
            this.level1IceLandToolStripMenuItem.Click += new System.EventHandler(this.level1IceLandToolStripMenuItem_Click);
            // 
            // level2RockyCanyonToolStripMenuItem
            // 
            this.level2RockyCanyonToolStripMenuItem.Name = "level2RockyCanyonToolStripMenuItem";
            this.level2RockyCanyonToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.level2RockyCanyonToolStripMenuItem.Text = "Level 2 - Destroyed City";
            this.level2RockyCanyonToolStripMenuItem.Click += new System.EventHandler(this.level2RockyCanyonToolStripMenuItem_Click);
            // 
            // level3MagmaDragoonToolStripMenuItem
            // 
            this.level3MagmaDragoonToolStripMenuItem.Name = "level3MagmaDragoonToolStripMenuItem";
            this.level3MagmaDragoonToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.level3MagmaDragoonToolStripMenuItem.Text = "Level 3 - Magma Dragoon";
            this.level3MagmaDragoonToolStripMenuItem.Click += new System.EventHandler(this.level3MagmaDragoonToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.helpToolStripMenuItem.Text = "Exit";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // ProL
            // 
            this.ProL.BackColor = System.Drawing.Color.Red;
            this.ProL.ForeColor = System.Drawing.Color.Lime;
            this.ProL.Location = new System.Drawing.Point(25, 27);
            this.ProL.Name = "ProL";
            this.ProL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProL.Size = new System.Drawing.Size(514, 20);
            this.ProL.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProL.TabIndex = 10;
            this.ProL.Value = 100;
            // 
            // BtnLvl
            // 
            this.BtnLvl.Location = new System.Drawing.Point(430, 244);
            this.BtnLvl.Name = "BtnLvl";
            this.BtnLvl.Size = new System.Drawing.Size(108, 26);
            this.BtnLvl.TabIndex = 18;
            this.BtnLvl.Text = "Next Level";
            this.BtnLvl.UseVisualStyleBackColor = true;
            this.BtnLvl.Visible = false;
            this.BtnLvl.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(560, 398);
            this.Controls.Add(this.BtnLvl);
            this.Controls.Add(this.ProL);
            this.Controls.Add(this.LstDis);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                       Megaman X";
            this.Load += new System.EventHandler(this.Mega_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Mega_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mega_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mega_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer TimRun;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.ListBox LstDis;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level1IceLandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level2RockyCanyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level3MagmaDragoonToolStripMenuItem;
        private System.Windows.Forms.ProgressBar ProL;
        private System.Windows.Forms.Button BtnLvl;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

