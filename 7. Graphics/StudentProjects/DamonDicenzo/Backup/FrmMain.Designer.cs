namespace GuitarHeroClone
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TimTitle = new System.Windows.Forms.Timer(this.components);
            this.PicPlay1 = new System.Windows.Forms.PictureBox();
            this.PicScores1 = new System.Windows.Forms.PictureBox();
            this.PicAbout = new System.Windows.Forms.PictureBox();
            this.PicQuit = new System.Windows.Forms.PictureBox();
            this.PicAbout2 = new System.Windows.Forms.PictureBox();
            this.PicPlay2 = new System.Windows.Forms.PictureBox();
            this.PicScores2 = new System.Windows.Forms.PictureBox();
            this.PicQuit2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicScores1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAbout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicScores2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit2)).BeginInit();
            this.SuspendLayout();
            // 
            // TimTitle
            // 
            this.TimTitle.Enabled = true;
            this.TimTitle.Tick += new System.EventHandler(this.TimTitle_Tick);
            // 
            // PicPlay1
            // 
            this.PicPlay1.BackColor = System.Drawing.Color.Transparent;
            this.PicPlay1.Image = ((System.Drawing.Image)(resources.GetObject("PicPlay1.Image")));
            this.PicPlay1.Location = new System.Drawing.Point(144, 294);
            this.PicPlay1.Name = "PicPlay1";
            this.PicPlay1.Size = new System.Drawing.Size(150, 57);
            this.PicPlay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlay1.TabIndex = 0;
            this.PicPlay1.TabStop = false;
            this.PicPlay1.Click += new System.EventHandler(this.PicPlay1_Click);
            this.PicPlay1.MouseHover += new System.EventHandler(this.PicPlay1_MouseHover);
            // 
            // PicScores1
            // 
            this.PicScores1.BackColor = System.Drawing.Color.Transparent;
            this.PicScores1.Image = ((System.Drawing.Image)(resources.GetObject("PicScores1.Image")));
            this.PicScores1.Location = new System.Drawing.Point(155, 345);
            this.PicScores1.Name = "PicScores1";
            this.PicScores1.Size = new System.Drawing.Size(173, 68);
            this.PicScores1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicScores1.TabIndex = 1;
            this.PicScores1.TabStop = false;
            this.PicScores1.Click += new System.EventHandler(this.PicScores1_Click);
            this.PicScores1.MouseHover += new System.EventHandler(this.PicScores1_MouseHover);
            // 
            // PicAbout
            // 
            this.PicAbout.BackColor = System.Drawing.Color.Transparent;
            this.PicAbout.Image = ((System.Drawing.Image)(resources.GetObject("PicAbout.Image")));
            this.PicAbout.Location = new System.Drawing.Point(175, 423);
            this.PicAbout.Name = "PicAbout";
            this.PicAbout.Size = new System.Drawing.Size(87, 43);
            this.PicAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicAbout.TabIndex = 2;
            this.PicAbout.TabStop = false;
            this.PicAbout.Click += new System.EventHandler(this.PicAbout_Click);
            this.PicAbout.MouseHover += new System.EventHandler(this.PicAbout_MouseHover);
            // 
            // PicQuit
            // 
            this.PicQuit.BackColor = System.Drawing.Color.Transparent;
            this.PicQuit.Image = ((System.Drawing.Image)(resources.GetObject("PicQuit.Image")));
            this.PicQuit.Location = new System.Drawing.Point(188, 481);
            this.PicQuit.Name = "PicQuit";
            this.PicQuit.Size = new System.Drawing.Size(68, 37);
            this.PicQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicQuit.TabIndex = 3;
            this.PicQuit.TabStop = false;
            this.PicQuit.Click += new System.EventHandler(this.PicQuit_Click);
            this.PicQuit.MouseHover += new System.EventHandler(this.PicQuit_MouseHover);
            // 
            // PicAbout2
            // 
            this.PicAbout2.BackColor = System.Drawing.Color.Transparent;
            this.PicAbout2.Image = ((System.Drawing.Image)(resources.GetObject("PicAbout2.Image")));
            this.PicAbout2.Location = new System.Drawing.Point(175, 420);
            this.PicAbout2.Name = "PicAbout2";
            this.PicAbout2.Size = new System.Drawing.Size(87, 43);
            this.PicAbout2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicAbout2.TabIndex = 4;
            this.PicAbout2.TabStop = false;
            this.PicAbout2.Visible = false;
            this.PicAbout2.MouseLeave += new System.EventHandler(this.PicAbout2_MouseLeave);
            this.PicAbout2.Click += new System.EventHandler(this.PicAbout2_Click);
            // 
            // PicPlay2
            // 
            this.PicPlay2.BackColor = System.Drawing.Color.Transparent;
            this.PicPlay2.Image = ((System.Drawing.Image)(resources.GetObject("PicPlay2.Image")));
            this.PicPlay2.Location = new System.Drawing.Point(144, 292);
            this.PicPlay2.Name = "PicPlay2";
            this.PicPlay2.Size = new System.Drawing.Size(150, 57);
            this.PicPlay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlay2.TabIndex = 5;
            this.PicPlay2.TabStop = false;
            this.PicPlay2.Visible = false;
            this.PicPlay2.MouseLeave += new System.EventHandler(this.PicPlay2_MouseLeave);
            this.PicPlay2.Click += new System.EventHandler(this.PicPlay2_Click);
            // 
            // PicScores2
            // 
            this.PicScores2.BackColor = System.Drawing.Color.Transparent;
            this.PicScores2.Image = ((System.Drawing.Image)(resources.GetObject("PicScores2.Image")));
            this.PicScores2.Location = new System.Drawing.Point(154, 347);
            this.PicScores2.Name = "PicScores2";
            this.PicScores2.Size = new System.Drawing.Size(173, 68);
            this.PicScores2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicScores2.TabIndex = 6;
            this.PicScores2.TabStop = false;
            this.PicScores2.Visible = false;
            this.PicScores2.MouseLeave += new System.EventHandler(this.PicScores2_MouseLeave);
            this.PicScores2.Click += new System.EventHandler(this.PicScores2_Click);
            // 
            // PicQuit2
            // 
            this.PicQuit2.BackColor = System.Drawing.Color.Transparent;
            this.PicQuit2.Image = ((System.Drawing.Image)(resources.GetObject("PicQuit2.Image")));
            this.PicQuit2.Location = new System.Drawing.Point(186, 479);
            this.PicQuit2.Name = "PicQuit2";
            this.PicQuit2.Size = new System.Drawing.Size(68, 37);
            this.PicQuit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicQuit2.TabIndex = 7;
            this.PicQuit2.TabStop = false;
            this.PicQuit2.Visible = false;
            this.PicQuit2.MouseLeave += new System.EventHandler(this.PicQuit2_MouseLeave);
            this.PicQuit2.Click += new System.EventHandler(this.PicQuit2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 562);
            this.Controls.Add(this.PicQuit2);
            this.Controls.Add(this.PicScores2);
            this.Controls.Add(this.PicPlay2);
            this.Controls.Add(this.PicAbout2);
            this.Controls.Add(this.PicQuit);
            this.Controls.Add(this.PicAbout);
            this.Controls.Add(this.PicScores1);
            this.Controls.Add(this.PicPlay1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero of Guitar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPlay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicScores1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAbout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicScores2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicQuit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimTitle;
        private System.Windows.Forms.PictureBox PicPlay1;
        private System.Windows.Forms.PictureBox PicScores1;
        private System.Windows.Forms.PictureBox PicAbout;
        private System.Windows.Forms.PictureBox PicQuit;
        private System.Windows.Forms.PictureBox PicAbout2;
        private System.Windows.Forms.PictureBox PicPlay2;
        private System.Windows.Forms.PictureBox PicScores2;
        private System.Windows.Forms.PictureBox PicQuit2;
    }
}

