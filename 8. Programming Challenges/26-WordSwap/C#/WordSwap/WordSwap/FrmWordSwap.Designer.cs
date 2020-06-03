namespace WordSwap
{
    partial class FrmWordSwap
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
            this.BtnWordSwap = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnWordSwap
            // 
            this.BtnWordSwap.Location = new System.Drawing.Point(270, 35);
            this.BtnWordSwap.Name = "BtnWordSwap";
            this.BtnWordSwap.Size = new System.Drawing.Size(138, 41);
            this.BtnWordSwap.TabIndex = 0;
            this.BtnWordSwap.Text = "Perform Word Swap";
            this.BtnWordSwap.UseVisualStyleBackColor = true;
            this.BtnWordSwap.Click += new System.EventHandler(this.BtnWordSwap_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(35, 128);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(610, 153);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmWordSwap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 330);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnWordSwap);
            this.Name = "FrmWordSwap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Swap Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWordSwap;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

