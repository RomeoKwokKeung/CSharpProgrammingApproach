namespace FMACatCatcher
{
    partial class frmgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgame));
            this.btnstartstop = new System.Windows.Forms.Button();
            this.edtimer = new System.Windows.Forms.Timer(this.components);
            this.hittimer = new System.Windows.Forms.Timer(this.components);
            this.catstimer = new System.Windows.Forms.Timer(this.components);
            this.catdirectiontimer = new System.Windows.Forms.Timer(this.components);
            this.catmovetimer = new System.Windows.Forms.Timer(this.components);
            this.countdowntimer = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstartstop
            // 
            this.btnstartstop.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstartstop.ForeColor = System.Drawing.Color.Firebrick;
            this.btnstartstop.Location = new System.Drawing.Point(824, 12);
            this.btnstartstop.Name = "btnstartstop";
            this.btnstartstop.Size = new System.Drawing.Size(89, 24);
            this.btnstartstop.TabIndex = 0;
            this.btnstartstop.Text = "Start";
            this.btnstartstop.UseVisualStyleBackColor = true;
            this.btnstartstop.Click += new System.EventHandler(this.btnstartstop_Click);
            // 
            // edtimer
            // 
            this.edtimer.Tick += new System.EventHandler(this.edtimer_Tick);
            // 
            // hittimer
            // 
            this.hittimer.Tick += new System.EventHandler(this.hittimer_Tick);
            // 
            // catstimer
            // 
            this.catstimer.Tick += new System.EventHandler(this.catstimer_Tick);
            // 
            // catdirectiontimer
            // 
            this.catdirectiontimer.Interval = 1000;
            this.catdirectiontimer.Tick += new System.EventHandler(this.catdirectiontimer_Tick);
            // 
            // catmovetimer
            // 
            this.catmovetimer.Interval = 10;
            this.catmovetimer.Tick += new System.EventHandler(this.catmovetimer_Tick);
            // 
            // countdowntimer
            // 
            this.countdowntimer.Interval = 1000;
            this.countdowntimer.Tick += new System.EventHandler(this.countdowntimer_Tick);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(12, 544);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer2.TabIndex = 1;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // frmgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(925, 579);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.btnstartstop);
            this.KeyPreview = true;
            this.Name = "frmgame";
            this.Text = "FMA Cat Catcher!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmgame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmgame_KeyDown);
            this.Load += new System.EventHandler(this.frmgame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstartstop;
        private System.Windows.Forms.Timer edtimer;
        private System.Windows.Forms.Timer hittimer;
        private System.Windows.Forms.Timer catstimer;
        private System.Windows.Forms.Timer catdirectiontimer;
        private System.Windows.Forms.Timer catmovetimer;
        private System.Windows.Forms.Timer countdowntimer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}