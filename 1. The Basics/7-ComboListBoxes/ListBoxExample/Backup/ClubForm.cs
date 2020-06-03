// ListBoxExample.cs    Author: Doyle
// This application includes Button, Label,
// Textbox and ListBox objects.
// SelectedIndexChanged and Click events fired.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListBoxExample
{
    public class ClubForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxEvents;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNewAct;
        private System.Windows.Forms.Button btnNew;
        private System.ComponentModel.Container components = null;
        public ClubForm(  )
        {
            InitializeComponent();
        }
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
        private void InitializeComponent()
        {
            this.lstBoxEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.txtBoxNewAct = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxEvents
            // 
            this.lstBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstBoxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstBoxEvents.ItemHeight = 20;
            this.lstBoxEvents.Items.AddRange(new object[] {
            "Amusement Park",
            "Boat Tour",
            "Dance",
            "Dinner",
            "Hike",
            "Movie",
            "Sporting Event"});
            this.lstBoxEvents.Location = new System.Drawing.Point(8, 40);
            this.lstBoxEvents.Name = "lstBoxEvents";
            this.lstBoxEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxEvents.Size = new System.Drawing.Size(152, 84);
            this.lstBoxEvents.Sorted = true;
            this.lstBoxEvents.TabIndex = 1;
            this.lstBoxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBoxEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Event(s)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add an Activity";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(-2, 240);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(296, 26);
            this.txtBoxResult.TabIndex = 3;
            // 
            // txtBoxNewAct
            // 
            this.txtBoxNewAct.Location = new System.Drawing.Point(128, 144);
            this.txtBoxNewAct.Name = "txtBoxNewAct";
            this.txtBoxNewAct.Size = new System.Drawing.Size(160, 26);
            this.txtBoxNewAct.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(80, 187);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 27);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Add New One";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ClubForm
            // 
            this.AcceptButton = this.btnNew;
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(292, 288);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBoxNewAct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBoxEvents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClubForm";
            this.Text = "Computer Club Outing Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
#endregion

        static void Main() 
        {
            Application.Run(new ClubForm());
        }

        private void lstBoxEvents_SelectedIndexChanged
                                         (object sender, System.EventArgs e)
        {

//            this.txtBoxResult.Text = this.lstBoxEvents.Text;   
                                           // Single selection option
            string result  =" ";
            foreach(string activity  in lstBoxEvents.SelectedItems)
                result  += activity + "    ";
            this.txtBoxResult.Text = result;
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            lstBoxEvents.Items.Add(txtBoxNewAct.Text);
            txtBoxNewAct.Clear( );

        }
     }
}
