namespace CanDoBetter
{
    partial class FrmDoBetter
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
            this.BtnDoBetter = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDoBetter
            // 
            this.BtnDoBetter.Location = new System.Drawing.Point(169, 45);
            this.BtnDoBetter.Name = "BtnDoBetter";
            this.BtnDoBetter.Size = new System.Drawing.Size(135, 29);
            this.BtnDoBetter.TabIndex = 0;
            this.BtnDoBetter.Text = "Do Better";
            this.BtnDoBetter.UseVisualStyleBackColor = true;
            this.BtnDoBetter.Click += new System.EventHandler(this.BtnDoBetter_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(94, 127);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(287, 135);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmDoBetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 353);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDoBetter);
            this.Name = "FrmDoBetter";
            this.Text = "Anything You Can Do, I Can Do Better";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDoBetter;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

