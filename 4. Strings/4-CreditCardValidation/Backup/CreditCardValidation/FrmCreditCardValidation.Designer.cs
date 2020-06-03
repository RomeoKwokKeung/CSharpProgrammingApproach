namespace CreditCardValidation
{
    partial class FrmCreditCardValidation
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
            this.BtnCredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCredit
            // 
            this.BtnCredit.Location = new System.Drawing.Point(129, 103);
            this.BtnCredit.Name = "BtnCredit";
            this.BtnCredit.Size = new System.Drawing.Size(118, 30);
            this.BtnCredit.TabIndex = 0;
            this.BtnCredit.Text = "Check Credit Card";
            this.BtnCredit.UseVisualStyleBackColor = true;
            this.BtnCredit.Click += new System.EventHandler(this.BtnCredit_Click);
            // 
            // FrmCreditCardValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.BtnCredit);
            this.Name = "FrmCreditCardValidation";
            this.Text = "Credit Card Validation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCredit;
    }
}

