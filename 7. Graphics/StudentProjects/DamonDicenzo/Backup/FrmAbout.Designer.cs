namespace GuitarHeroClone
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.PicReturnFromAbout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnFromAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // PicReturnFromAbout
            // 
            this.PicReturnFromAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicReturnFromAbout.Image = ((System.Drawing.Image)(resources.GetObject("PicReturnFromAbout.Image")));
            this.PicReturnFromAbout.Location = new System.Drawing.Point(633, 469);
            this.PicReturnFromAbout.Name = "PicReturnFromAbout";
            this.PicReturnFromAbout.Size = new System.Drawing.Size(83, 22);
            this.PicReturnFromAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicReturnFromAbout.TabIndex = 0;
            this.PicReturnFromAbout.TabStop = false;
            this.PicReturnFromAbout.Click += new System.EventHandler(this.PicReturnFromAbout_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 562);
            this.Controls.Add(this.PicReturnFromAbout);
            this.MaximizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero of Guitar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmAbout_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnFromAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicReturnFromAbout;
    }
}