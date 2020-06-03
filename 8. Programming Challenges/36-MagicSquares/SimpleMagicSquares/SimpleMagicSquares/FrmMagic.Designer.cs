namespace SimpleMagicSquares
{
    partial class FrmMagic
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
            this.BtnMagic = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMagic
            // 
            this.BtnMagic.Location = new System.Drawing.Point(239, 57);
            this.BtnMagic.Name = "BtnMagic";
            this.BtnMagic.Size = new System.Drawing.Size(154, 41);
            this.BtnMagic.TabIndex = 0;
            this.BtnMagic.Text = "Determine Magic Square";
            this.BtnMagic.UseVisualStyleBackColor = true;
            this.BtnMagic.Click += new System.EventHandler(this.BtnMagic_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(141, 153);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(358, 201);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmMagic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnMagic);
            this.Name = "FrmMagic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Square Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMagic;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

