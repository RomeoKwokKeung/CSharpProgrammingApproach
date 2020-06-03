namespace Palidromes
{
    partial class FrmPalidromes
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
            this.BtnPalidromes = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPalidromes
            // 
            this.BtnPalidromes.Location = new System.Drawing.Point(191, 73);
            this.BtnPalidromes.Name = "BtnPalidromes";
            this.BtnPalidromes.Size = new System.Drawing.Size(149, 43);
            this.BtnPalidromes.TabIndex = 0;
            this.BtnPalidromes.Text = "Find Palindromes";
            this.BtnPalidromes.UseVisualStyleBackColor = true;
            this.BtnPalidromes.Click += new System.EventHandler(this.BtnPalidromes_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(53, 151);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(425, 238);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPalidromes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 426);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPalidromes);
            this.Name = "FrmPalidromes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palindrome Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPalidromes;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

