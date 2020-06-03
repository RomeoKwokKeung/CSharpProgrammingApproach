namespace BarChart
{
    partial class FrmBarChart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHorizontal = new System.Windows.Forms.Button();
            this.BtnVertical = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(30, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 384);
            this.panel1.TabIndex = 0;
            // 
            // BtnHorizontal
            // 
            this.BtnHorizontal.Location = new System.Drawing.Point(105, 437);
            this.BtnHorizontal.Name = "BtnHorizontal";
            this.BtnHorizontal.Size = new System.Drawing.Size(84, 30);
            this.BtnHorizontal.TabIndex = 1;
            this.BtnHorizontal.Text = "Horizontal";
            this.BtnHorizontal.UseVisualStyleBackColor = true;
            this.BtnHorizontal.Click += new System.EventHandler(this.BtnHorizontal_Click);
            // 
            // BtnVertical
            // 
            this.BtnVertical.Location = new System.Drawing.Point(452, 439);
            this.BtnVertical.Name = "BtnVertical";
            this.BtnVertical.Size = new System.Drawing.Size(86, 28);
            this.BtnVertical.TabIndex = 2;
            this.BtnVertical.Text = "Vertical";
            this.BtnVertical.UseVisualStyleBackColor = true;
            this.BtnVertical.Click += new System.EventHandler(this.BtnVertical_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(280, 439);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(57, 28);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 491);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnVertical);
            this.Controls.Add(this.BtnHorizontal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar Chart Progarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHorizontal;
        private System.Windows.Forms.Button BtnVertical;
        private System.Windows.Forms.Button BtnExit;
    }
}

