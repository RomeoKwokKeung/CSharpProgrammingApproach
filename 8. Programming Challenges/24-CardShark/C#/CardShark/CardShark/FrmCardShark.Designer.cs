namespace CardShark
{
    partial class FrmCardShark
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
            this.BtnShark = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnShark
            // 
            this.BtnShark.Location = new System.Drawing.Point(158, 46);
            this.BtnShark.Name = "BtnShark";
            this.BtnShark.Size = new System.Drawing.Size(162, 43);
            this.BtnShark.TabIndex = 0;
            this.BtnShark.Text = "Fold or Play ?";
            this.BtnShark.UseVisualStyleBackColor = true;
            this.BtnShark.Click += new System.EventHandler(this.BtnShark_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(50, 120);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(376, 224);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmCardShark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnShark);
            this.Name = "FrmCardShark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Shark Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShark;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

