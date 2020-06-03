namespace MetricImperial
{
    partial class FrmMetricImperial
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
            this.BtnMetricImperial = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMetricImperial
            // 
            this.BtnMetricImperial.Location = new System.Drawing.Point(161, 50);
            this.BtnMetricImperial.Name = "BtnMetricImperial";
            this.BtnMetricImperial.Size = new System.Drawing.Size(150, 46);
            this.BtnMetricImperial.TabIndex = 0;
            this.BtnMetricImperial.Text = "Perform Conversions";
            this.BtnMetricImperial.UseVisualStyleBackColor = true;
            this.BtnMetricImperial.Click += new System.EventHandler(this.BtnMetricImperial_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(70, 137);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(349, 185);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmMetricImperial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 379);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnMetricImperial);
            this.Name = "FrmMetricImperial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metric Imperial Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMetricImperial;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

