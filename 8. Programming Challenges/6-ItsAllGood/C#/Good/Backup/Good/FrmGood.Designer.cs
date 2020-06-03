namespace Good
{
    partial class FrmGood
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
            this.BtnGood = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGood
            // 
            this.BtnGood.Location = new System.Drawing.Point(208, 67);
            this.BtnGood.Name = "BtnGood";
            this.BtnGood.Size = new System.Drawing.Size(127, 35);
            this.BtnGood.TabIndex = 0;
            this.BtnGood.Text = "Determine Fix or Good";
            this.BtnGood.UseVisualStyleBackColor = true;
            this.BtnGood.Click += new System.EventHandler(this.BtnGood_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(74, 148);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(409, 203);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 406);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnGood);
            this.Name = "FrmGood";
            this.Text = "It\'s All Good";           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGood;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

