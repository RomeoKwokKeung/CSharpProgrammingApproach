namespace SongMethod
{
    partial class FrmSongMethod
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
            this.TxtSong = new System.Windows.Forms.TextBox();
            this.BtnWithoutMethod = new System.Windows.Forms.Button();
            this.BtnWithMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSong
            // 
            this.TxtSong.Location = new System.Drawing.Point(216, 44);
            this.TxtSong.Multiline = true;
            this.TxtSong.Name = "TxtSong";
            this.TxtSong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSong.Size = new System.Drawing.Size(192, 170);
            this.TxtSong.TabIndex = 0;
            // 
            // BtnWithoutMethod
            // 
            this.BtnWithoutMethod.Location = new System.Drawing.Point(78, 44);
            this.BtnWithoutMethod.Name = "BtnWithoutMethod";
            this.BtnWithoutMethod.Size = new System.Drawing.Size(99, 29);
            this.BtnWithoutMethod.TabIndex = 1;
            this.BtnWithoutMethod.Text = "Without Method";
            this.BtnWithoutMethod.UseVisualStyleBackColor = true;
            this.BtnWithoutMethod.Click += new System.EventHandler(this.BtnWithoutMethod_Click);
            // 
            // BtnWithMethod
            // 
            this.BtnWithMethod.Location = new System.Drawing.Point(78, 104);
            this.BtnWithMethod.Name = "BtnWithMethod";
            this.BtnWithMethod.Size = new System.Drawing.Size(98, 27);
            this.BtnWithMethod.TabIndex = 2;
            this.BtnWithMethod.Text = "With Method";
            this.BtnWithMethod.UseVisualStyleBackColor = true;
            this.BtnWithMethod.Click += new System.EventHandler(this.BtnWithMethod_Click);
            // 
            // FrmSongMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.BtnWithMethod);
            this.Controls.Add(this.BtnWithoutMethod);
            this.Controls.Add(this.TxtSong);
            this.Name = "FrmSongMethod";
            this.Text = "Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSong;
        private System.Windows.Forms.Button BtnWithoutMethod;
        private System.Windows.Forms.Button BtnWithMethod;
    }
}

