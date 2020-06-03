namespace Craps
{
    partial class FrmCraps
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
            this.BtnCraps = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCraps
            // 
            this.BtnCraps.Location = new System.Drawing.Point(177, 43);
            this.BtnCraps.Name = "BtnCraps";
            this.BtnCraps.Size = new System.Drawing.Size(137, 43);
            this.BtnCraps.TabIndex = 0;
            this.BtnCraps.Text = "Check Craps Game Results";
            this.BtnCraps.UseVisualStyleBackColor = true;
            this.BtnCraps.Click += new System.EventHandler(this.BtnCraps_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(76, 121);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(356, 132);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmCraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 294);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnCraps);
            this.Name = "FrmCraps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Craps Game Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCraps;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

