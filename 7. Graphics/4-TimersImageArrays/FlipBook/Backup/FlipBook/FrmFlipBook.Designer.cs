namespace FlipBook
{
    partial class FrmFlipBook
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
            this.PicPlayer = new System.Windows.Forms.PictureBox();
            this.BtnBegin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // PicPlayer
            // 
            this.PicPlayer.Location = new System.Drawing.Point(85, 27);
            this.PicPlayer.Name = "PicPlayer";
            this.PicPlayer.Size = new System.Drawing.Size(171, 132);
            this.PicPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer.TabIndex = 0;
            this.PicPlayer.TabStop = false;
            // 
            // BtnBegin
            // 
            this.BtnBegin.Location = new System.Drawing.Point(124, 205);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(73, 28);
            this.BtnBegin.TabIndex = 1;
            this.BtnBegin.Text = "Start/Stop";
            this.BtnBegin.UseVisualStyleBackColor = true;
            this.BtnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmFlipBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.BtnBegin);
            this.Controls.Add(this.PicPlayer);
            this.Name = "FrmFlipBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hand Drawn Animation";
            this.Load += new System.EventHandler(this.FrmFlipBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPlayer;
        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.Timer timer1;
    }
}

