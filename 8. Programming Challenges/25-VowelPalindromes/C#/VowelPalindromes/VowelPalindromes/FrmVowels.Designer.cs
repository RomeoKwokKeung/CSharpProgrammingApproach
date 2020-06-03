namespace VowelPalindromes
{
    partial class FrmVowels
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
            this.BtnVowels = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnVowels
            // 
            this.BtnVowels.Location = new System.Drawing.Point(196, 57);
            this.BtnVowels.Name = "BtnVowels";
            this.BtnVowels.Size = new System.Drawing.Size(123, 35);
            this.BtnVowels.TabIndex = 0;
            this.BtnVowels.Text = "Determine Vowel Palindromes";
            this.BtnVowels.UseVisualStyleBackColor = true;
            this.BtnVowels.Click += new System.EventHandler(this.BtnVowels_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(33, 130);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(451, 146);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmVowels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 312);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnVowels);
            this.Name = "FrmVowels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vowel Palindrome Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVowels;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

