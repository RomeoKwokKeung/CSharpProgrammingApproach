namespace TimeClock
{
    partial class FrmTimeClock
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
            this.BtnTimeClock = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTimeClock
            // 
            this.BtnTimeClock.Location = new System.Drawing.Point(211, 56);
            this.BtnTimeClock.Name = "BtnTimeClock";
            this.BtnTimeClock.Size = new System.Drawing.Size(127, 23);
            this.BtnTimeClock.TabIndex = 0;
            this.BtnTimeClock.Text = "Determine Times";
            this.BtnTimeClock.UseVisualStyleBackColor = true;
            this.BtnTimeClock.Click += new System.EventHandler(this.BtnTimeClock_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(129, 132);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(297, 181);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmTimeClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 371);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnTimeClock);
            this.Name = "FrmTimeClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Clock Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTimeClock;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

