namespace TheTippingPoint
{
    partial class FrmTippingPoint
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
            this.BtnDetermine = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDetermine
            // 
            this.BtnDetermine.Location = new System.Drawing.Point(165, 50);
            this.BtnDetermine.Name = "BtnDetermine";
            this.BtnDetermine.Size = new System.Drawing.Size(148, 35);
            this.BtnDetermine.TabIndex = 0;
            this.BtnDetermine.Text = "Determine The Tipping Point";
            this.BtnDetermine.UseVisualStyleBackColor = true;
            this.BtnDetermine.Click += new System.EventHandler(this.BtnDetermine_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(133, 145);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(219, 171);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmTippingPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 360);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDetermine);
            this.Name = "FrmTippingPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Tipping Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDetermine;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

