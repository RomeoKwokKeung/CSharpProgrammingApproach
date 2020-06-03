namespace SingleDigit
{
    partial class FrmSingleDigit
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
            this.BtnSingleDigit = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSingleDigit
            // 
            this.BtnSingleDigit.Location = new System.Drawing.Point(68, 38);
            this.BtnSingleDigit.Name = "BtnSingleDigit";
            this.BtnSingleDigit.Size = new System.Drawing.Size(143, 37);
            this.BtnSingleDigit.TabIndex = 0;
            this.BtnSingleDigit.Text = "Determine Single Digit";
            this.BtnSingleDigit.UseVisualStyleBackColor = true;
            this.BtnSingleDigit.Click += new System.EventHandler(this.BtnSingleDigit_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(22, 94);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(237, 148);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmSingleDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSingleDigit);
            this.Name = "FrmSingleDigit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Digit Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSingleDigit;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

