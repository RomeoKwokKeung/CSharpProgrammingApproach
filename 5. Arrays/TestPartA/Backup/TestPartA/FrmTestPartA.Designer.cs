namespace TestPartA
{
    partial class FrmTestPartA
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
            this.BtnSales = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSales
            // 
            this.BtnSales.Location = new System.Drawing.Point(131, 23);
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.Size = new System.Drawing.Size(137, 28);
            this.BtnSales.TabIndex = 0;
            this.BtnSales.Text = "Perform Sales Analysis";
            this.BtnSales.UseVisualStyleBackColor = true;
            this.BtnSales.Click += new System.EventHandler(this.BtnSales_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(169, 225);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 25);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(39, 68);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(344, 128);
            this.TxtDisplay.TabIndex = 2;
            // 
            // FrmTestPartA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSales);
            this.Name = "FrmTestPartA";
            this.Text = "Part A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSales;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

