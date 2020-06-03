namespace FinalGameAssignment
{
    partial class FrmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnScores = new System.Windows.Forms.Button();
            this.TxtHelp = new System.Windows.Forms.TextBox();
            this.Wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.TmrMusic = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.White;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnStart.Location = new System.Drawing.Point(188, 32);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(126, 40);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Begin";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnExit.Location = new System.Drawing.Point(188, 240);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(126, 40);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.White;
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnHelp.Location = new System.Drawing.Point(90, 212);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(126, 40);
            this.BtnHelp.TabIndex = 2;
            this.BtnHelp.Text = "How To Play";
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnScores
            // 
            this.BtnScores.BackColor = System.Drawing.Color.White;
            this.BtnScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnScores.Location = new System.Drawing.Point(90, 12);
            this.BtnScores.Name = "BtnScores";
            this.BtnScores.Size = new System.Drawing.Size(136, 42);
            this.BtnScores.TabIndex = 3;
            this.BtnScores.Text = "Digimon Champions";
            this.BtnScores.UseVisualStyleBackColor = false;
            this.BtnScores.Click += new System.EventHandler(this.BtnScores_Click);
            // 
            // TxtHelp
            // 
            this.TxtHelp.BackColor = System.Drawing.Color.White;
            this.TxtHelp.ForeColor = System.Drawing.Color.Black;
            this.TxtHelp.Location = new System.Drawing.Point(74, 117);
            this.TxtHelp.Multiline = true;
            this.TxtHelp.Name = "TxtHelp";
            this.TxtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHelp.Size = new System.Drawing.Size(270, 57);
            this.TxtHelp.TabIndex = 4;
            this.TxtHelp.Visible = false;
            // 
            // Wmp1
            // 
            this.Wmp1.Enabled = true;
            this.Wmp1.Location = new System.Drawing.Point(354, 273);
            this.Wmp1.Name = "Wmp1";
            this.Wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wmp1.OcxState")));
            this.Wmp1.Size = new System.Drawing.Size(75, 23);
            this.Wmp1.TabIndex = 5;
            this.Wmp1.Visible = false;
            // 
            // TmrMusic
            // 
            this.TmrMusic.Enabled = true;
            this.TmrMusic.Interval = 49000;
            this.TmrMusic.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 319);
            this.Controls.Add(this.Wmp1);
            this.Controls.Add(this.TxtHelp);
            this.Controls.Add(this.BtnScores);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnStart);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digimon Adventure";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStart_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnScores;
        private System.Windows.Forms.TextBox TxtHelp;
        private AxWMPLib.AxWindowsMediaPlayer Wmp1;
        private System.Windows.Forms.Timer TmrMusic;
    }
}