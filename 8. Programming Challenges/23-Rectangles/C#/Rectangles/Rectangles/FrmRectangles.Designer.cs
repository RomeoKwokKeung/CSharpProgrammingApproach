namespace Rectangles
{
    partial class FrmRectangles
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
            this.BtnRectangles = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRectangles
            // 
            this.BtnRectangles.Location = new System.Drawing.Point(167, 50);
            this.BtnRectangles.Name = "BtnRectangles";
            this.BtnRectangles.Size = new System.Drawing.Size(146, 47);
            this.BtnRectangles.TabIndex = 0;
            this.BtnRectangles.Text = "Determine Overlap";
            this.BtnRectangles.UseVisualStyleBackColor = true;
            this.BtnRectangles.Click += new System.EventHandler(this.BtnRectangles_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(45, 132);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(392, 402);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmRectangles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 559);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnRectangles);
            this.Name = "FrmRectangles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangles Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRectangles;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

