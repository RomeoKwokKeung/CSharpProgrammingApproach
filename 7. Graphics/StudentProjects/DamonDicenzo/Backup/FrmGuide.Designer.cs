namespace GuitarHeroClone
{
    partial class FrmGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuide));
            this.PicContinue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicContinue)).BeginInit();
            this.SuspendLayout();
            // 
            // PicContinue
            // 
            this.PicContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicContinue.Image = ((System.Drawing.Image)(resources.GetObject("PicContinue.Image")));
            this.PicContinue.Location = new System.Drawing.Point(324, 415);
            this.PicContinue.Name = "PicContinue";
            this.PicContinue.Size = new System.Drawing.Size(151, 57);
            this.PicContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicContinue.TabIndex = 0;
            this.PicContinue.TabStop = false;
            this.PicContinue.Click += new System.EventHandler(this.PicContinue_Click);
            // 
            // FrmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 562);
            this.Controls.Add(this.PicContinue);
            this.MaximizeBox = false;
            this.Name = "FrmGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero of Guitar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGuide_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PicContinue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicContinue;
    }
}