namespace ArrayIntermediate
{
    partial class FrmIntermediate
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
            this.BtnGrades = new System.Windows.Forms.Button();
            this.BtnTemp = new System.Windows.Forms.Button();
            this.LstInfo = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGrades
            // 
            this.BtnGrades.Location = new System.Drawing.Point(37, 56);
            this.BtnGrades.Name = "BtnGrades";
            this.BtnGrades.Size = new System.Drawing.Size(94, 32);
            this.BtnGrades.TabIndex = 0;
            this.BtnGrades.Text = "Grades";
            this.BtnGrades.UseVisualStyleBackColor = true;
            this.BtnGrades.Click += new System.EventHandler(this.BtnGrades_Click);
            // 
            // BtnTemp
            // 
            this.BtnTemp.Location = new System.Drawing.Point(37, 129);
            this.BtnTemp.Name = "BtnTemp";
            this.BtnTemp.Size = new System.Drawing.Size(93, 31);
            this.BtnTemp.TabIndex = 1;
            this.BtnTemp.Text = "Temperatures";
            this.BtnTemp.UseVisualStyleBackColor = true;
            this.BtnTemp.Click += new System.EventHandler(this.BtnTemp_Click);
            // 
            // LstInfo
            // 
            this.LstInfo.FormattingEnabled = true;
            this.LstInfo.Location = new System.Drawing.Point(180, 30);
            this.LstInfo.Name = "LstInfo";
            this.LstInfo.Size = new System.Drawing.Size(211, 186);
            this.LstInfo.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(250, 222);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(74, 28);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmIntermediate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstInfo);
            this.Controls.Add(this.BtnTemp);
            this.Controls.Add(this.BtnGrades);
            this.Name = "FrmIntermediate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intermediate Array Applications";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGrades;
        private System.Windows.Forms.Button BtnTemp;
        private System.Windows.Forms.ListBox LstInfo;
        private System.Windows.Forms.Button BtnExit;
    }
}

