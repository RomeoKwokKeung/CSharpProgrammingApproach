namespace Qwerty
{
    partial class FrmQwerty
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
            this.BtnQWERTY = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnQWERTY
            // 
            this.BtnQWERTY.Location = new System.Drawing.Point(246, 74);
            this.BtnQWERTY.Name = "BtnQWERTY";
            this.BtnQWERTY.Size = new System.Drawing.Size(149, 23);
            this.BtnQWERTY.TabIndex = 0;
            this.BtnQWERTY.Text = "QWERTY ";
            this.BtnQWERTY.UseVisualStyleBackColor = true;
            this.BtnQWERTY.Click += new System.EventHandler(this.BtnQWERTY_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(86, 150);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(526, 209);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmQwerty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 421);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnQWERTY);
            this.Name = "FrmQwerty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QWERTY Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnQWERTY;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

