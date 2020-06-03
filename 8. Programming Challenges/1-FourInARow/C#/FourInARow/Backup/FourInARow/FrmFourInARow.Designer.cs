namespace FourInARow
{
    partial class FrmFourInARow
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
            this.BtnFourInARow = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFourInARow
            // 
            this.BtnFourInARow.Location = new System.Drawing.Point(205, 62);
            this.BtnFourInARow.Name = "BtnFourInARow";
            this.BtnFourInARow.Size = new System.Drawing.Size(136, 36);
            this.BtnFourInARow.TabIndex = 0;
            this.BtnFourInARow.Text = "Determine Four In A Row";
            this.BtnFourInARow.UseVisualStyleBackColor = true;
            this.BtnFourInARow.Click += new System.EventHandler(this.BtnFourInARow_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(41, 155);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(482, 194);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmFourInARow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 425);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnFourInARow);
            this.Name = "FrmFourInARow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Four In A Row Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFourInARow;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

