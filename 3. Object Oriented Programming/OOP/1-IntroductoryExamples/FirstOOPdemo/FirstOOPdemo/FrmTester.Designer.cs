namespace FirstOOPdemo
{
    partial class FrmTester
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
            this.BtnClassTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClassTest
            // 
            this.BtnClassTest.Location = new System.Drawing.Point(91, 103);
            this.BtnClassTest.Name = "BtnClassTest";
            this.BtnClassTest.Size = new System.Drawing.Size(104, 31);
            this.BtnClassTest.TabIndex = 0;
            this.BtnClassTest.Text = "Test Class";
            this.BtnClassTest.UseVisualStyleBackColor = true;
            this.BtnClassTest.Click += new System.EventHandler(this.BtnClassTest_Click);
            // 
            // FrmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnClassTest);
            this.Name = "FrmTester";
            this.Text = "Main Form Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClassTest;
    }
}

