namespace GuitarHeroClone
{
    partial class FrmSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSong));
            this.PicSong1 = new System.Windows.Forms.PictureBox();
            this.TimTitle = new System.Windows.Forms.Timer(this.components);
            this.PicSong2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicSong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSong2)).BeginInit();
            this.SuspendLayout();
            // 
            // PicSong1
            // 
            this.PicSong1.BackColor = System.Drawing.Color.Transparent;
            this.PicSong1.Image = ((System.Drawing.Image)(resources.GetObject("PicSong1.Image")));
            this.PicSong1.InitialImage = null;
            this.PicSong1.Location = new System.Drawing.Point(46, 256);
            this.PicSong1.Name = "PicSong1";
            this.PicSong1.Size = new System.Drawing.Size(405, 109);
            this.PicSong1.TabIndex = 0;
            this.PicSong1.TabStop = false;
            this.PicSong1.Click += new System.EventHandler(this.PicSong1_Click);
            this.PicSong1.MouseHover += new System.EventHandler(this.PicSong1_MouseHover);
            // 
            // TimTitle
            // 
            this.TimTitle.Enabled = true;
            this.TimTitle.Tick += new System.EventHandler(this.TimTitle_Tick);
            // 
            // PicSong2
            // 
            this.PicSong2.BackColor = System.Drawing.Color.Transparent;
            this.PicSong2.Image = ((System.Drawing.Image)(resources.GetObject("PicSong2.Image")));
            this.PicSong2.InitialImage = null;
            this.PicSong2.Location = new System.Drawing.Point(46, 256);
            this.PicSong2.Name = "PicSong2";
            this.PicSong2.Size = new System.Drawing.Size(405, 109);
            this.PicSong2.TabIndex = 1;
            this.PicSong2.TabStop = false;
            this.PicSong2.Visible = false;
            this.PicSong2.MouseLeave += new System.EventHandler(this.PicSong2_MouseLeave);
            this.PicSong2.Click += new System.EventHandler(this.PicSong2_Click);
            // 
            // FrmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(807, 562);
            this.Controls.Add(this.PicSong2);
            this.Controls.Add(this.PicSong1);
            this.MaximizeBox = false;
            this.Name = "FrmSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero of Guitar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmSong_Paint);
            this.Load += new System.EventHandler(this.FrmSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSong2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicSong1;
        private System.Windows.Forms.Timer TimTitle;
        private System.Windows.Forms.PictureBox PicSong2;
    }
}