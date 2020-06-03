namespace AddTimes
{
    partial class FrmAddTimes
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
            this.BtnAddTimes = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddTimes
            // 
            this.BtnAddTimes.Location = new System.Drawing.Point(209, 48);
            this.BtnAddTimes.Name = "BtnAddTimes";
            this.BtnAddTimes.Size = new System.Drawing.Size(131, 45);
            this.BtnAddTimes.TabIndex = 0;
            this.BtnAddTimes.Text = "Add Times";
            this.BtnAddTimes.UseVisualStyleBackColor = true;
            this.BtnAddTimes.Click += new System.EventHandler(this.BtnAddTimes_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(61, 128);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(446, 193);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmAddTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 369);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnAddTimes);
            this.Name = "FrmAddTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Times Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddTimes;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

