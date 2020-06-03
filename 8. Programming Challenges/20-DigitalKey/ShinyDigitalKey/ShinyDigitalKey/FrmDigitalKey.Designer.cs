namespace ShinyDigitalKey
{
    partial class FrmDigitalKey
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
            this.BtnDigitalKey = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDigitalKey
            // 
            this.BtnDigitalKey.Location = new System.Drawing.Point(163, 51);
            this.BtnDigitalKey.Name = "BtnDigitalKey";
            this.BtnDigitalKey.Size = new System.Drawing.Size(147, 39);
            this.BtnDigitalKey.TabIndex = 0;
            this.BtnDigitalKey.Text = "Determine Digital Key";
            this.BtnDigitalKey.UseVisualStyleBackColor = true;
            this.BtnDigitalKey.Click += new System.EventHandler(this.BtnDigitalKey_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(52, 129);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(379, 268);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmDigitalKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 426);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDigitalKey);
            this.Name = "FrmDigitalKey";
            this.Text = "Digital Key Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDigitalKey;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

