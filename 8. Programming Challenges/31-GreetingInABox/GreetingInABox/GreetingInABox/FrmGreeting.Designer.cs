namespace GreetingInABox
{
    partial class FrmGreeting
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
            this.BtnGreeting = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGreeting
            // 
            this.BtnGreeting.Location = new System.Drawing.Point(278, 40);
            this.BtnGreeting.Name = "BtnGreeting";
            this.BtnGreeting.Size = new System.Drawing.Size(107, 35);
            this.BtnGreeting.TabIndex = 0;
            this.BtnGreeting.Text = "Display Greetings";
            this.BtnGreeting.UseVisualStyleBackColor = true;
            this.BtnGreeting.Click += new System.EventHandler(this.BtnGreeting_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(47, 118);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(575, 265);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmGreeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 417);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnGreeting);
            this.Name = "FrmGreeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greeting In A Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGreeting;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

