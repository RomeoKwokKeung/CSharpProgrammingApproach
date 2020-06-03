namespace ClassGraphics
{
    partial class FrmClassGraphics
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
            this.BtnFace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFace
            // 
            this.BtnFace.Location = new System.Drawing.Point(202, 298);
            this.BtnFace.Name = "BtnFace";
            this.BtnFace.Size = new System.Drawing.Size(91, 25);
            this.BtnFace.TabIndex = 0;
            this.BtnFace.Text = "Draw Faces";
            this.BtnFace.UseVisualStyleBackColor = true;
            this.BtnFace.Click += new System.EventHandler(this.BtnFace_Click);
            // 
            // FrmClassGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 352);
            this.Controls.Add(this.BtnFace);
            this.Name = "FrmClassGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Classes for Graphical Images";
            this.Load += new System.EventHandler(this.FrmClassGraphics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFace;
    }
}

