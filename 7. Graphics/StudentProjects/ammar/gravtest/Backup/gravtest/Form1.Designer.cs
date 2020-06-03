namespace gravtest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Motion = new System.Windows.Forms.Timer(this.components);
            this.Gravity = new System.Windows.Forms.Timer(this.components);
            this.WaddleAnimation = new System.Windows.Forms.Timer(this.components);
            this.Wattack = new System.Windows.Forms.Timer(this.components);
            this.Smash = new System.Windows.Forms.Timer(this.components);
            this.Gravity2 = new System.Windows.Forms.Timer(this.components);
            this.pnlgame = new gravtest.BfPnl();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Motion
            // 
            this.Motion.Enabled = true;
            this.Motion.Interval = 10;
            this.Motion.Tick += new System.EventHandler(this.Motion_Tick);
            // 
            // Gravity
            // 
            this.Gravity.Tick += new System.EventHandler(this.Gravity_Tick);
            // 
            // WaddleAnimation
            // 
            this.WaddleAnimation.Enabled = true;
            this.WaddleAnimation.Interval = 1;
            this.WaddleAnimation.Tick += new System.EventHandler(this.WaddleAnimation_Tick);
            // 
            // Wattack
            // 
            this.Wattack.Enabled = true;
            this.Wattack.Interval = 1;
            this.Wattack.Tick += new System.EventHandler(this.Wattack_Tick);
            // 
            // Smash
            // 
            this.Smash.Enabled = true;
            this.Smash.Interval = 10;
            this.Smash.Tick += new System.EventHandler(this.Smash_Tick);
            // 
            // Gravity2
            // 
            this.Gravity2.Tick += new System.EventHandler(this.Gravity2_Tick);
            // 
            // pnlgame
            // 
            this.pnlgame.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnlgame.Location = new System.Drawing.Point(12, 12);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(627, 493);
            this.pnlgame.TabIndex = 0;
            this.pnlgame.Paint += new System.Windows.Forms.PaintEventHandler(this.bfPnl1_Paint);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(300, 212);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(105, 44);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 517);
            this.Controls.Add(this.pnlgame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "SSB ICS3U1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlgame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Motion;
        private System.Windows.Forms.Timer Gravity;
        private BfPnl pnlgame;
        private System.Windows.Forms.Timer WaddleAnimation;
        private System.Windows.Forms.Timer Wattack;
        private System.Windows.Forms.Timer Smash;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer Gravity2;
        
    }
}

