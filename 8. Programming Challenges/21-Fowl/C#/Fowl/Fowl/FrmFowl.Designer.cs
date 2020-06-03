namespace Fowl
{
    partial class FrmFowl
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
            this.BtnFowl = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFowl
            // 
            this.BtnFowl.Location = new System.Drawing.Point(115, 41);
            this.BtnFowl.Name = "BtnFowl";
            this.BtnFowl.Size = new System.Drawing.Size(151, 42);
            this.BtnFowl.TabIndex = 0;
            this.BtnFowl.Text = "Determine If Target Hit";
            this.BtnFowl.UseVisualStyleBackColor = true;
            this.BtnFowl.Click += new System.EventHandler(this.BtnFowl_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(46, 125);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(287, 195);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmFowl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 364);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnFowl);
            this.Name = "FrmFowl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrage Fowl Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFowl;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

