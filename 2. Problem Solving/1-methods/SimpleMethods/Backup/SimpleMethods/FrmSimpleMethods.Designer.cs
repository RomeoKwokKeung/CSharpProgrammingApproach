namespace SimpleMethods
{
    partial class FrmSimpleMethods
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
            this.BtnMethodReturn = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMethodReturn
            // 
            this.BtnMethodReturn.Location = new System.Drawing.Point(59, 42);
            this.BtnMethodReturn.Name = "BtnMethodReturn";
            this.BtnMethodReturn.Size = new System.Drawing.Size(170, 32);
            this.BtnMethodReturn.TabIndex = 0;
            this.BtnMethodReturn.Text = "A Method That Returns a Value";
            this.BtnMethodReturn.UseVisualStyleBackColor = true;
            this.BtnMethodReturn.Click += new System.EventHandler(this.BtnMethodReturn_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(98, 219);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(81, 21);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmSimpleMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMethodReturn);
            this.Name = "FrmSimpleMethods";
            this.Text = "Using Methods Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMethodReturn;
        private System.Windows.Forms.Button BtnExit;
    }
}

