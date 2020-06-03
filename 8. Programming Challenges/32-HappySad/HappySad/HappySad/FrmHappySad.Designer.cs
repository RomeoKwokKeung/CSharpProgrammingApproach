namespace HappySad
{
    partial class FrmHappySad
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
            this.BtnHappySad = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnHappySad
            // 
            this.BtnHappySad.Location = new System.Drawing.Point(272, 39);
            this.BtnHappySad.Name = "BtnHappySad";
            this.BtnHappySad.Size = new System.Drawing.Size(130, 37);
            this.BtnHappySad.TabIndex = 0;
            this.BtnHappySad.Text = "Determine Emoticon ";
            this.BtnHappySad.UseVisualStyleBackColor = true;
            this.BtnHappySad.Click += new System.EventHandler(this.BtnHappySad_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(62, 111);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(547, 198);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmHappySad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 354);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnHappySad);
            this.Name = "FrmHappySad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Sad Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHappySad;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

