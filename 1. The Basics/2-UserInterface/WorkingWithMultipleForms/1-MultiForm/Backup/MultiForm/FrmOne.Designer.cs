namespace MultiForm
{
    partial class FrmOne
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
            this.BtnOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOne
            // 
            this.BtnOne.Location = new System.Drawing.Point(102, 97);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(88, 37);
            this.BtnOne.TabIndex = 0;
            this.BtnOne.Text = "Goto Second Form";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // FrmOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnOne);
            this.Name = "FrmOne";
            this.Text = "First Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOne;
    }
}

