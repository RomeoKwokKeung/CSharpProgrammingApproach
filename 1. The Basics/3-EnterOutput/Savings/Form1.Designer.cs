namespace Savings
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lblDepositHeading = new System.Windows.Forms.Label();
            this.lblWeeksHeading = new System.Windows.Forms.Label();
            this.lblTotalHeading = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtWeeks = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
// 
// lblDepositHeading
// 
            this.lblDepositHeading.AutoSize = true;
            this.lblDepositHeading.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositHeading.Location = new System.Drawing.Point(13, 18);
            this.lblDepositHeading.Name = "lblDepositHeading";
            this.lblDepositHeading.Size = new System.Drawing.Size(98, 17);
            this.lblDepositHeading.TabIndex = 0;
            this.lblDepositHeading.Text = "Weekly Deposit";
// 
// lblWeeksHeading
// 
            this.lblWeeksHeading.AutoSize = true;
            this.lblWeeksHeading.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeksHeading.Location = new System.Drawing.Point(13, 46);
            this.lblWeeksHeading.Name = "lblWeeksHeading";
            this.lblWeeksHeading.Size = new System.Drawing.Size(112, 17);
            this.lblWeeksHeading.TabIndex = 1;
            this.lblWeeksHeading.Text = "Number of Weeks";
// 
// lblTotalHeading
// 
            this.lblTotalHeading.AutoSize = true;
            this.lblTotalHeading.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHeading.Location = new System.Drawing.Point(13, 77);
            this.lblTotalHeading.Name = "lblTotalHeading";
            this.lblTotalHeading.Size = new System.Drawing.Size(86, 17);
            this.lblTotalHeading.TabIndex = 2;
            this.lblTotalHeading.Text = "Total Savings";
// 
// txtDeposit
// 
            this.txtDeposit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(132, 18);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.TabIndex = 3;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
// 
// txtWeeks
// 
            this.txtWeeks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeeks.Location = new System.Drawing.Point(132, 46);
            this.txtWeeks.Name = "txtWeeks";
            this.txtWeeks.TabIndex = 4;
            this.txtWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
// 
// txtTotal
// 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(132, 77);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
// 
// btnCompute
// 
            this.btnCompute.Location = new System.Drawing.Point(28, 112);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
// 
// btnExit
// 
            this.btnExit.Location = new System.Drawing.Point(132, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
// 
// Form1
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.ClientSize = new System.Drawing.Size(245, 149);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtWeeks);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblTotalHeading);
            this.Controls.Add(this.lblWeeksHeading);
            this.Controls.Add(this.lblDepositHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepositHeading;
        private System.Windows.Forms.Label lblWeeksHeading;
        private System.Windows.Forms.Label lblTotalHeading;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtWeeks;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnExit;
    }
}

