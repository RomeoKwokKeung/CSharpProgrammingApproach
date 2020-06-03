using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MakeChange
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txtCost;
		private System.Windows.Forms.TextBox txtOffered;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.txtOffered = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total Cost";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 50);
			this.label2.TabIndex = 1;
			this.label2.Text = "Money Presented";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCost
			// 
			this.txtCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCost.Location = new System.Drawing.Point(24, 64);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(72, 26);
			this.txtCost.TabIndex = 2;
			this.txtCost.Text = "";
			this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtOffered
			// 
			this.txtOffered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtOffered.Location = new System.Drawing.Point(160, 64);
			this.txtOffered.Name = "txtOffered";
			this.txtOffered.Size = new System.Drawing.Size(72, 26);
			this.txtOffered.TabIndex = 3;
			this.txtOffered.Text = "";
			this.txtOffered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(24, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Make Change";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(152, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Change";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(152, 128);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(112, 132);
			this.listBox1.TabIndex = 6;
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
			this.ClientSize = new System.Drawing.Size(292, 278);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.listBox1,
																		  this.label3,
																		  this.button1,
																		  this.txtOffered,
																		  this.txtCost,
																		  this.label2,
																		  this.label1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Changemaker";
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

		private void DisplayChange(decimal diff)
		{

			if (diff >= 100)
			{
				listBox1.Items.Add(((int)diff/100).ToString() + " Hundred(s)");
				diff -= ((int)diff/100)*100;
			}
			if (diff >= 50)
			{
				listBox1.Items.Add("1 Fifty");
				diff -= 50;
			}
			if (diff >= 20)
			{
				listBox1.Items.Add(((int)diff/20).ToString() + " Twenty(s)");
				diff -= ((int)diff/20)*20;
			}
			if (diff >= 10)
			{
				listBox1.Items.Add("1 Ten");
				diff -= 10;
			}
			if (diff >= 5)
			{
				listBox1.Items.Add("1 Five");
				diff -= 5;
			}
			if (diff >= 1)
			{
				listBox1.Items.Add(((int)diff/1).ToString() + " One(s)");
				diff -= ((int)(diff/1m))*1m;
			}
			if (diff >= .25m)
			{
				listBox1.Items.Add(((int)(diff/.25m)).ToString() + " Quarter(s)");
				diff = diff % .25m;
			}
			if (diff >= .1m)
			{
				listBox1.Items.Add(((int)(diff/.1m)).ToString() + " Dimes(s)");
				diff -= (int)(diff/.1m) * .1m;
			}	
			if (diff >= .05m)
			{
				listBox1.Items.Add("1 Nickle");
				diff -= .05m;
			}
			if (diff >= .01m)
			{
				listBox1.Items.Add(((int)(diff/.01m)).ToString() + " Penny(s)");
				diff -= (int)(diff/.01m) * .01m;
			}	
			if (diff != 0) listBox1.Items.Add(diff.ToString());

		}
		private void button1_Click(object sender, System.EventArgs e)
	{
			try
			{
				decimal cost = decimal.Parse(txtCost.Text);
				decimal offered = decimal.Parse(txtOffered.Text);
				listBox1.Items.Clear();
				if (cost > offered)
					MessageBox.Show("You need more money","ChangeMaker");
				else
				{
					decimal diff = Math.Abs(offered - cost);
					DisplayChange(diff);
				}
			}
			catch
			{
				txtCost.Text="";
				txtOffered.Text="";
				txtCost.Focus();
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
