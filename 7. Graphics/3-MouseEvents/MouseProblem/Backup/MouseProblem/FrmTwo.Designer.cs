namespace MouseProblem
{
    partial class FrmTwo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicReturnB = new System.Windows.Forms.PictureBox();
            this.PicReturnA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MouseProblem.Properties.Resources.page2red;
            this.pictureBox1.Location = new System.Drawing.Point(76, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PicReturnB
            // 
            this.PicReturnB.Image = global::MouseProblem.Properties.Resources.ARW06LT;
            this.PicReturnB.Location = new System.Drawing.Point(209, 215);
            this.PicReturnB.Name = "PicReturnB";
            this.PicReturnB.Size = new System.Drawing.Size(23, 18);
            this.PicReturnB.TabIndex = 4;
            this.PicReturnB.TabStop = false;
            this.PicReturnB.Visible = false;
            // 
            // PicReturnA
            // 
            this.PicReturnA.Image = global::MouseProblem.Properties.Resources.ARW06UP;
            this.PicReturnA.Location = new System.Drawing.Point(215, 215);
            this.PicReturnA.Name = "PicReturnA";
            this.PicReturnA.Size = new System.Drawing.Size(17, 20);
            this.PicReturnA.TabIndex = 3;
            this.PicReturnA.TabStop = false;
            this.PicReturnA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicReturnA_MouseDown);
            this.PicReturnA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicReturnA_MouseUp);
            // 
            // FrmTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.PicReturnB);
            this.Controls.Add(this.PicReturnA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTwo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicReturnB;
        private System.Windows.Forms.PictureBox PicReturnA;
    }
}