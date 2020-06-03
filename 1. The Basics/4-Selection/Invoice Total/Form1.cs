using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication1
{
    /// <summary>
    /// Invoice Total form
    /// </summary>
    /// <remarks>
    /// Murach's C# by Joel Murach & Doug Lowe. 
    /// Chapter 5 Invoice Total application. 
    /// (c) 2004 by Mike Murach & Associates, Inc. 
    /// www.murach.com
    /// </remarks>
    public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label lblDiscountPercent;
		private System.Windows.Forms.Label lblDiscountAmount;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.TextBox txtCustomerType;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
        // Downloaded from www.murach.com (Chapter 5 Invoice Total application)
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblDiscountPercent = new System.Windows.Forms.Label();
			this.lblDiscountAmount = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtCustomerType = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Subtotal:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Discount amount:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Total:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(112, 44);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(84, 20);
			this.txtSubtotal.TabIndex = 2;
			this.txtSubtotal.Text = "";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(24, 168);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(73, 27);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(112, 168);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 27);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Discount percent:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDiscountPercent
			// 
			this.lblDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDiscountPercent.Location = new System.Drawing.Point(112, 72);
			this.lblDiscountPercent.Name = "lblDiscountPercent";
			this.lblDiscountPercent.Size = new System.Drawing.Size(84, 20);
			this.lblDiscountPercent.TabIndex = 0;
			this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDiscountAmount
			// 
			this.lblDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDiscountAmount.Location = new System.Drawing.Point(112, 100);
			this.lblDiscountAmount.Name = "lblDiscountAmount";
			this.lblDiscountAmount.Size = new System.Drawing.Size(84, 20);
			this.lblDiscountAmount.TabIndex = 0;
			this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotal
			// 
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotal.Location = new System.Drawing.Point(112, 128);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(84, 20);
			this.lblTotal.TabIndex = 0;
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCustomerType
			// 
			this.txtCustomerType.Location = new System.Drawing.Point(112, 16);
			this.txtCustomerType.Name = "txtCustomerType";
			this.txtCustomerType.Size = new System.Drawing.Size(84, 20);
			this.txtCustomerType.TabIndex = 1;
			this.txtCustomerType.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Customer type:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(213, 205);
			this.Controls.Add(this.txtCustomerType);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblDiscountAmount);
			this.Controls.Add(this.lblDiscountPercent);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Invoice Total";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnCalculate_Click(object sender, System.EventArgs e)
		{
			string customerType = txtCustomerType.Text;
			decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
			decimal discountPercent = .0m;

			if (customerType == "R")
			{
				if (subtotal < 100)
					discountPercent = .0m;
				else if (subtotal >= 100 && subtotal < 250)
					discountPercent = .1m;
				else if (subtotal >= 250)
					discountPercent = .25m;
			}
			else if (customerType == "C")
			{
				if (subtotal < 250)
					discountPercent = .2m;
				else
					discountPercent = .3m;
			}
			else
				discountPercent = .4m;
					
			decimal discountAmount = subtotal * discountPercent;
			decimal invoiceTotal = subtotal - discountAmount;

            lblDiscountPercent.Text = discountPercent.ToString("p1");
            lblDiscountAmount.Text = discountAmount.ToString("c");
            lblTotal.Text = invoiceTotal.ToString("c");

			txtCustomerType.Focus();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
