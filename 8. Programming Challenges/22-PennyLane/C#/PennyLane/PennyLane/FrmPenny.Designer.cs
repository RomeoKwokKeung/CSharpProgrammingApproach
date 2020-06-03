namespace PennyLane
{
    partial class FrmPenny
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
            this.BtnPenny = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPenny
            // 
            this.BtnPenny.Location = new System.Drawing.Point(129, 51);
            this.BtnPenny.Name = "BtnPenny";
            this.BtnPenny.Size = new System.Drawing.Size(142, 38);
            this.BtnPenny.TabIndex = 0;
            this.BtnPenny.Text = "Determine Coin Amounts";
            this.BtnPenny.UseVisualStyleBackColor = true;
            this.BtnPenny.Click += new System.EventHandler(this.BtnPenny_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(49, 126);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(311, 182);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPenny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 355);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPenny);
            this.Name = "FrmPenny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penny Lane Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPenny;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

