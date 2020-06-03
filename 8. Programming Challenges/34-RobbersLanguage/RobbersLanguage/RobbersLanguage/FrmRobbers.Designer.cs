namespace RobbersLanguage
{
    partial class FrmRobbers
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
            this.BtnRobbers = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRobbers
            // 
            this.BtnRobbers.Location = new System.Drawing.Point(312, 44);
            this.BtnRobbers.Name = "BtnRobbers";
            this.BtnRobbers.Size = new System.Drawing.Size(160, 39);
            this.BtnRobbers.TabIndex = 0;
            this.BtnRobbers.Text = "Convert To Robbers Language";
            this.BtnRobbers.UseVisualStyleBackColor = true;
            this.BtnRobbers.Click += new System.EventHandler(this.BtnRobbers_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(108, 141);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(560, 246);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmRobbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnRobbers);
            this.Name = "FrmRobbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robbers Language Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRobbers;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

