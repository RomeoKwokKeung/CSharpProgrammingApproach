namespace ComboBoxDemo
{
    partial class FrmComboBoxDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboEmployeeNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VsbHours = new System.Windows.Forms.VScrollBar();
            this.TxtHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGrossPay = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCompute = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // CboEmployeeNames
            // 
            this.CboEmployeeNames.FormattingEnabled = true;
            this.CboEmployeeNames.Items.AddRange(new object[] {
            "Tom Smith",
            "Karen Jones",
            "Sam Mattina",
            "Mary Carpenter",
            "Louise Kenmore",
            "Pat Len"});
            this.CboEmployeeNames.Location = new System.Drawing.Point(80, 44);
            this.CboEmployeeNames.Name = "CboEmployeeNames";
            this.CboEmployeeNames.Size = new System.Drawing.Size(121, 21);
            this.CboEmployeeNames.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours";
            // 
            // VsbHours
            // 
            this.VsbHours.Location = new System.Drawing.Point(185, 89);
            this.VsbHours.Name = "VsbHours";
            this.VsbHours.Size = new System.Drawing.Size(15, 77);
            this.VsbHours.TabIndex = 3;
            this.VsbHours.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VsbHours_Scroll);
            // 
            // TxtHours
            // 
            this.TxtHours.Location = new System.Drawing.Point(124, 99);
            this.TxtHours.Name = "TxtHours";
            this.TxtHours.Size = new System.Drawing.Size(42, 20);
            this.TxtHours.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate";
            // 
            // CboRate
            // 
            this.CboRate.FormattingEnabled = true;
            this.CboRate.Location = new System.Drawing.Point(124, 184);
            this.CboRate.Name = "CboRate";
            this.CboRate.Size = new System.Drawing.Size(73, 21);
            this.CboRate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gross Pay";
            // 
            // TxtGrossPay
            // 
            this.TxtGrossPay.Location = new System.Drawing.Point(148, 234);
            this.TxtGrossPay.Name = "TxtGrossPay";
            this.TxtGrossPay.Size = new System.Drawing.Size(64, 20);
            this.TxtGrossPay.TabIndex = 8;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(16, 275);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(53, 25);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(101, 275);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(64, 24);
            this.BtnCompute.TabIndex = 10;
            this.BtnCompute.Text = "Compute";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(207, 275);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(54, 23);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmComboBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 309);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCompute);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtGrossPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtHours);
            this.Controls.Add(this.VsbHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboEmployeeNames);
            this.Controls.Add(this.label1);
            this.Name = "FrmComboBoxDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box Demo";
            this.Load += new System.EventHandler(this.FrmComboBoxDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboEmployeeNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar VsbHours;
        private System.Windows.Forms.TextBox TxtHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGrossPay;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Button BtnExit;
    }
}

