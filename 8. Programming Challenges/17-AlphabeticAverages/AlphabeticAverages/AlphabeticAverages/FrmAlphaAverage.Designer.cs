namespace AlphabeticAverages
{
    partial class FrmAlphaAverage
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
            this.BtnAlphaAverage = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAlphaAverage
            // 
            this.BtnAlphaAverage.Location = new System.Drawing.Point(158, 34);
            this.BtnAlphaAverage.Name = "BtnAlphaAverage";
            this.BtnAlphaAverage.Size = new System.Drawing.Size(127, 32);
            this.BtnAlphaAverage.TabIndex = 0;
            this.BtnAlphaAverage.Text = "Determine Averages";
            this.BtnAlphaAverage.UseVisualStyleBackColor = true;
            this.BtnAlphaAverage.Click += new System.EventHandler(this.BtnAlphaAverage_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(51, 99);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(374, 121);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmAlphaAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnAlphaAverage);
            this.Name = "FrmAlphaAverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alphabetic Averages Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAlphaAverage;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

