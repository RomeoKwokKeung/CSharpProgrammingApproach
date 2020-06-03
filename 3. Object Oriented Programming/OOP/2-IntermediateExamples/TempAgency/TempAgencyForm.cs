// TempAgencyForm.cs         
// Builds the Graphical User Interface
// Includes button, label, textbox and form objects

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PayRollApp
{
    public class TempAgencyForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblSoc;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtFed;
        private System.Windows.Forms.TextBox txtSoc;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Button btnReset;

        // Required designer variable.
        private System.ComponentModel.Container components = null;

        public TempAgencyForm()
        {
            InitializeComponent();
        }
        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblFed = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblSoc = new System.Windows.Forms.Label();
            this.lblAgency = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtFed = new System.Windows.Forms.TextBox();
            this.txtSoc = new System.Windows.Forms.TextBox();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";

            // lblHours
            // 
            this.lblHours.Location = new System.Drawing.Point(8, 80);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(176, 23);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "No. of Hours Worked:";

            // lblDep
            this.lblDep.Location = new System.Drawing.Point(8, 120);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(160, 23);
            this.lblDep.TabIndex = 2;
            this.lblDep.Text = "No. of Dependents:";

            // label4
            this.label4.Font = new System.Drawing.Font("Comic Sans MS",
                14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(144, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "XYZ JobSource";

            // lblNet
            this.lblNet.Location = new System.Drawing.Point(136, 392);
            this.lblNet.Name = "lblNet";
            this.lblNet.TabIndex = 4;
            this.lblNet.Text = "Net Pay:";
            this.lblNet.Visible = false;

            // lblFed
            this.lblFed.Location = new System.Drawing.Point(144, 288);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(112, 23);
            this.lblFed.TabIndex = 5;
            this.lblFed.Text = "Federal Ded:";
            this.lblFed.Visible = false;

            // lblGross
            this.lblGross.Location = new System.Drawing.Point(136, 256);
            this.lblGross.Name = "lblGross";
            this.lblGross.TabIndex = 6;
            this.lblGross.Text = "Gross Pay:";
            this.lblGross.Visible = false;

            // lblSoc
            this.lblSoc.Location = new System.Drawing.Point(144, 320);
            this.lblSoc.Name = "lblSoc";
            this.lblSoc.Size = new System.Drawing.Size(120, 23);
            this.lblSoc.TabIndex = 7;
            this.lblSoc.Text = "Soc Sec. Ded:";
            this.lblSoc.Visible = false;

            // lblAgency
            this.lblAgency.Location = new System.Drawing.Point(144, 352);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.TabIndex = 8;
            this.lblAgency.Text = "Agency Fee:";
            this.lblAgency.Visible = false;

            // txtName
            this.txtName.AcceptsReturn = true;
            this.txtName.Location = new System.Drawing.Point(64, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 30);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "";

            // txtHours
            this.txtHours.AcceptsReturn = true;
            this.txtHours.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHours.Location = new System.Drawing.Point(184, 80);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(32, 30);
            this.txtHours.TabIndex = 10;
            this.txtHours.Text = "";
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // txtDep
            this.txtDep.Location = new System.Drawing.Point(184, 120);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(32, 30);
            this.txtDep.TabIndex = 11;
            this.txtDep.Text = "";
            this.txtDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // txtGross
            this.txtGross.BackColor = System.Drawing.Color.FromArgb
                (((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
            this.txtGross.Location = new System.Drawing.Point(224, 248);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(120, 30);
            this.txtGross.TabIndex = 12;
            this.txtGross.Text = "";
            this.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGross.Visible = false;

            // txtFed
            this.txtFed.BackColor = System.Drawing.Color.FromArgb
                (((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
            this.txtFed.Location = new System.Drawing.Point(264, 288);
            this.txtFed.Name = "txtFed";
            this.txtFed.Size = new System.Drawing.Size(80, 30);
            this.txtFed.TabIndex = 13;
            this.txtFed.Text = "";
            this.txtFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFed.Visible = false;

            // txtSoc
            this.txtSoc.BackColor = System.Drawing.Color.FromArgb
                (((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
            this.txtSoc.Location = new System.Drawing.Point(264, 320);
            this.txtSoc.Name = "txtSoc";
            this.txtSoc.Size = new System.Drawing.Size(80, 30);
            this.txtSoc.TabIndex = 14;
            this.txtSoc.Text = "";
            this.txtSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoc.Visible = false;

            // txtAgency
            this.txtAgency.BackColor = System.Drawing.Color.FromArgb
                (((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
            this.txtAgency.Location = new System.Drawing.Point(264, 352);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(80, 30);
            this.txtAgency.TabIndex = 15;
            this.txtAgency.Text = "";
            this.txtAgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAgency.Visible = false;

            // txtNet
            this.txtNet.BackColor = System.Drawing.Color.FromArgb
                (((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
            this.txtNet.Font = new System.Drawing.Font("Comic Sans MS",
                12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
            this.txtNet.Location = new System.Drawing.Point(224, 392);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(120, 30);
            this.txtNet.TabIndex = 16;
            this.txtNet.Text = "";
            this.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNet.Visible = false;

            // btnCalculate
            this.btnCalculate.ForeColor = System.Drawing.Color.Yellow;
            this.btnCalculate.Location = new System.Drawing.Point(48, 184);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 56);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate Take Home Pay";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnReset
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.ForeColor = System.Drawing.Color.Yellow;
            this.btnReset.Location = new System.Drawing.Point(264, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 56);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset Display";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // TempAgencyForm
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 23);
            this.BackColor = System.Drawing.Color.FromArgb
                (((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.btnReset,
                                                                          this.btnCalculate,
                                                                          this.txtNet,
                                                                          this.txtAgency,
                                                                          this.txtSoc,
                                                                          this.txtFed,
                                                                          this.txtGross,
                                                                          this.txtDep,
                                                                          this.txtHours,
                                                                          this.txtName,
                                                                          this.lblAgency,
                                                                          this.lblSoc,
                                                                          this.lblGross,
                                                                          this.lblFed,
                                                                          this.lblNet,
                                                                          this.label4,
                                                                          this.lblDep,
                                                                          this.lblHours,
                                                                          this.label1});
            this.Font = new System.Drawing.Font("Comic Sans MS",
                12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb
                (((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
            this.Name = "Form1";
            this.Text = "PayRoll Application";
            this.ResumeLayout(false);
        }
        #endregion

        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.Run(new TempAgencyForm());
        }

        // Button click event handler for the Calculate  button
        private void btnCalculate_Click(object sender, System.EventArgs e)
        {
            int dep;
            double hours;
            hours = double.Parse((txtHours.Text));
            dep = int.Parse((txtDep.Text));
            Employee anEmployee =
                new Employee(txtName.Text, hours, dep);
            txtGross.Text = anEmployee.Gross.ToString("C");
            txtSoc.Text = anEmployee.SocialSecurity.ToString("C");
            txtFed.Text = anEmployee.FederalTax.ToString("C");
            txtAgency.Text = anEmployee.AgencyFee.ToString("C");
            txtNet.Text = anEmployee.Net.ToString("C");
            txtName.Enabled = false;
            txtHours.Visible = false;
            txtDep.Visible = false;
            lblHours.Visible = false;
            lblDep.Visible = false;
            setVisibility(true);
        }

        // Button click event handler for the Reset button
        private void btnReset_Click(object sender, System.EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtDep.Clear();
            txtName.Enabled = true;
            txtHours.Visible = true;
            txtDep.Visible = true;
            lblHours.Visible = true;
            lblDep.Visible = true;
            setVisibility(false);
        }

        // Used by both the btnCalculate and btnReset to
        // change the visibility on the objects below the buttons
        private void setVisibility(bool visibilityValue)
        {
            lblGross.Visible = visibilityValue;
            lblSoc.Visible = visibilityValue;
            lblFed.Visible = visibilityValue;
            lblAgency.Visible = visibilityValue;
            lblNet.Visible = visibilityValue;
            txtGross.Visible = visibilityValue;
            txtSoc.Visible = visibilityValue;
            txtFed.Visible = visibilityValue;
            txtAgency.Visible = visibilityValue;
            txtNet.Visible = visibilityValue;
        }
    }
}