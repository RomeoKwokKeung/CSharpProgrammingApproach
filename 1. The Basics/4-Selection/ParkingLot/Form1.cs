using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ParkingLot
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblFee;
		private System.Windows.Forms.RadioButton rCar;
		private System.Windows.Forms.RadioButton rTruck;
		private System.Windows.Forms.Button btnStandard;
		private System.Windows.Forms.Button btnEvent;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblFee = new System.Windows.Forms.Label();
			this.rCar = new System.Windows.Forms.RadioButton();
			this.rTruck = new System.Windows.Forms.RadioButton();
			this.btnStandard = new System.Windows.Forms.Button();
			this.btnEvent = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// txtTime
			// 
			this.txtTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTime.Location = new System.Drawing.Point(16, 48);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(56, 26);
			this.txtTime.TabIndex = 0;
			this.txtTime.Text = "";
			this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hours Parked";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(208, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fee";
			// 
			// lblFee
			// 
			this.lblFee.BackColor = System.Drawing.Color.White;
			this.lblFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFee.Location = new System.Drawing.Point(200, 48);
			this.lblFee.Name = "lblFee";
			this.lblFee.Size = new System.Drawing.Size(64, 26);
			this.lblFee.TabIndex = 3;
			this.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rCar
			// 
			this.rCar.Checked = true;
			this.rCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rCar.Location = new System.Drawing.Point(96, 24);
			this.rCar.Name = "rCar";
			this.rCar.Size = new System.Drawing.Size(72, 24);
			this.rCar.TabIndex = 4;
			this.rCar.TabStop = true;
			this.rCar.Text = "Car";
			// 
			// rTruck
			// 
			this.rTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rTruck.Location = new System.Drawing.Point(96, 48);
			this.rTruck.Name = "rTruck";
			this.rTruck.Size = new System.Drawing.Size(72, 24);
			this.rTruck.TabIndex = 5;
			this.rTruck.Text = "Truck";
			// 
			// btnStandard
			// 
			this.btnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnStandard.Location = new System.Drawing.Point(80, 80);
			this.btnStandard.Name = "btnStandard";
			this.btnStandard.Size = new System.Drawing.Size(96, 32);
			this.btnStandard.TabIndex = 6;
			this.btnStandard.Text = "Standard";
			this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
			// 
			// btnEvent
			// 
			this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnEvent.Location = new System.Drawing.Point(80, 120);
			this.btnEvent.Name = "btnEvent";
			this.btnEvent.Size = new System.Drawing.Size(96, 32);
			this.btnEvent.TabIndex = 7;
			this.btnEvent.Text = "Event Rate";
			this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "E&xit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 174);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnEvent,
																		  this.btnStandard,
																		  this.rTruck,
																		  this.rCar,
																		  this.lblFee,
																		  this.label2,
																		  this.label1,
																		  this.txtTime});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Parking Lot Cashier";
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

		private void btnEvent_Click(object sender, System.EventArgs e)
		{
			lblFee.Text= 19.ToString("C");
		}

		private void btnStandard_Click(object sender, System.EventArgs e)
		{
			double OneHour = 5;
			double AddHours = 3;
			double MaxDay = 38;
			if (rTruck.Checked)
			{
				OneHour = 6;
				AddHours = 3.5;
				MaxDay = 44.50;
			}
			try
			{
				int myTime = int.Parse(txtTime.Text);
				if (myTime <= 2)
					lblFee.Text = OneHour.ToString("C");
				else
					if (myTime > 12)
				{
					if (myTime > 24)
					{
						int myDays = myTime / 24;
						if (myTime % 24 != 0) myDays++;
						lblFee.Text = (MaxDay * (myDays)).ToString("C");
					}
					else
						lblFee.Text = MaxDay.ToString("C");
				}
				else
					lblFee.Text = (OneHour + (myTime-1) * AddHours).ToString("C");
			}
			catch
			{
				txtTime.Text = "";
			}
			finally
			{
				txtTime.SelectAll();
				txtTime.Focus();
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

	}
}
