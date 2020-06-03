namespace OddSum
{
    partial class FrmOddSum
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
            this.BtnOddSum = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOddSum
            // 
            this.BtnOddSum.Location = new System.Drawing.Point(331, 65);
            this.BtnOddSum.Name = "BtnOddSum";
            this.BtnOddSum.Size = new System.Drawing.Size(135, 32);
            this.BtnOddSum.TabIndex = 0;
            this.BtnOddSum.Text = "Determine Odd Sum";
            this.BtnOddSum.UseVisualStyleBackColor = true;
            this.BtnOddSum.Click += new System.EventHandler(this.BtnOddSum_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(117, 157);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(560, 230);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmOddSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnOddSum);
            this.Name = "FrmOddSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odd Sum Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOddSum;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

