namespace MouseProblem
{
    partial class FrmOne
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
            this.PicReturnB = new System.Windows.Forms.PictureBox();
            this.PicReturnA = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicReturnB
            // 
            this.PicReturnB.Image = global::MouseProblem.Properties.Resources.ARW06LT;
            this.PicReturnB.Location = new System.Drawing.Point(209, 221);
            this.PicReturnB.Name = "PicReturnB";
            this.PicReturnB.Size = new System.Drawing.Size(23, 18);
            this.PicReturnB.TabIndex = 2;
            this.PicReturnB.TabStop = false;
            this.PicReturnB.Visible = false;
            // 
            // PicReturnA
            // 
            this.PicReturnA.Image = global::MouseProblem.Properties.Resources.ARW06UP;
            this.PicReturnA.Location = new System.Drawing.Point(215, 221);
            this.PicReturnA.Name = "PicReturnA";
            this.PicReturnA.Size = new System.Drawing.Size(17, 20);
            this.PicReturnA.TabIndex = 1;
            this.PicReturnA.TabStop = false;
            this.PicReturnA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicReturnA_MouseDown);
            this.PicReturnA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicReturnA_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MouseProblem.Properties.Resources.page1red;
            this.pictureBox1.Location = new System.Drawing.Point(77, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.PicReturnB);
            this.Controls.Add(this.PicReturnA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOne";
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicReturnA;
        private System.Windows.Forms.PictureBox PicReturnB;
    }
}