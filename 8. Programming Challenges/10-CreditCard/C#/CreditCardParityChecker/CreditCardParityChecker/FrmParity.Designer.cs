namespace CreditCardParityChecker
{
    partial class FrmParity
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
            this.BtnParity = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnParity
            // 
            this.BtnParity.Location = new System.Drawing.Point(254, 58);
            this.BtnParity.Name = "BtnParity";
            this.BtnParity.Size = new System.Drawing.Size(139, 36);
            this.BtnParity.TabIndex = 0;
            this.BtnParity.Text = "Parity Check";
            this.BtnParity.UseVisualStyleBackColor = true;
            this.BtnParity.Click += new System.EventHandler(this.BtnParity_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(61, 130);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(529, 226);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmParity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 427);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnParity);
            this.Name = "FrmParity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card Parity Checker Problem ... LUHN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnParity;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

