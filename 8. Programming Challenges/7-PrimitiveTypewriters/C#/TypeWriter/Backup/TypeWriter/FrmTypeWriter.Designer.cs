namespace TypeWriter
{
    partial class FrmTypeWriter
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
            this.BtnCost = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCost
            // 
            this.BtnCost.Location = new System.Drawing.Point(144, 40);
            this.BtnCost.Name = "BtnCost";
            this.BtnCost.Size = new System.Drawing.Size(163, 38);
            this.BtnCost.TabIndex = 0;
            this.BtnCost.Text = "Determine Cost";
            this.BtnCost.UseVisualStyleBackColor = true;
            this.BtnCost.Click += new System.EventHandler(this.BtnCost_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(60, 118);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(332, 161);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmTypeWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 315);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnCost);
            this.Name = "FrmTypeWriter";
            this.Text = "Primitive Typewriter Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCost;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

