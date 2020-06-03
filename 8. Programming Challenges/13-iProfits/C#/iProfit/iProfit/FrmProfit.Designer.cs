namespace iProfit
{
    partial class FrmProfit
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
            this.BtnProfit = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnProfit
            // 
            this.BtnProfit.Location = new System.Drawing.Point(180, 51);
            this.BtnProfit.Name = "BtnProfit";
            this.BtnProfit.Size = new System.Drawing.Size(177, 41);
            this.BtnProfit.TabIndex = 0;
            this.BtnProfit.Text = "Determine Threshold Profit";
            this.BtnProfit.UseVisualStyleBackColor = true;
            this.BtnProfit.Click += new System.EventHandler(this.BtnProfit_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(64, 162);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(420, 251);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 463);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnProfit);
            this.Name = "FrmProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iProfit Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProfit;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

