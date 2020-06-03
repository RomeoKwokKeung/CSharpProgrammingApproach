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
            this.btnVisa = new System.Windows.Forms.Button();
            this.btnSchneider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCredit
            // 
            this.BtnCredit.Location = new System.Drawing.Point(128, 40);
            this.BtnCredit.Name = "BtnCredit";
            this.BtnCredit.Size = new System.Drawing.Size(118, 30);
            this.BtnCredit.TabIndex = 0;
            this.BtnCredit.Text = "Check Credit Card";
            this.BtnCredit.UseVisualStyleBackColor = true;
            this.BtnCredit.Click += new System.EventHandler(this.BtnCredit_Click);
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(128, 163);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(118, 30);
            this.btnVisa.TabIndex = 1;
            this.btnVisa.Text = "Check Visa Card";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // btnSchneider
            // 
            this.btnSchneider.Location = new System.Drawing.Point(128, 101);
            this.btnSchneider.Name = "btnSchneider";
            this.btnSchneider.Size = new System.Drawing.Size(118, 30);
            this.btnSchneider.TabIndex = 2;
            this.btnSchneider.Text = "Schneider Code";
            this.btnSchneider.UseVisualStyleBackColor = true;
            this.btnSchneider.Click += new System.EventHandler(this.btnSchneider_Click);
            // 
            // FrmCreditCardValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.btnSchneider);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.BtnCredit);
            this.Name = "FrmCreditCardValidation";
            this.Text = "Credit Card Validation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCredit;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Button btnSchneider;
    }
}

