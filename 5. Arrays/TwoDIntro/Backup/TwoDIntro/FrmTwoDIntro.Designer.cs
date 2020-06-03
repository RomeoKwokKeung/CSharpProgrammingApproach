namespace TwoDIntro
{
    partial class FrmTwoDIntro
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
            this.BtnLoadDisplay = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnLoadDisplayNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoadDisplay
            // 
            this.BtnLoadDisplay.Location = new System.Drawing.Point(29, 12);
            this.BtnLoadDisplay.Name = "BtnLoadDisplay";
            this.BtnLoadDisplay.Size = new System.Drawing.Size(104, 47);
            this.BtnLoadDisplay.TabIndex = 0;
            this.BtnLoadDisplay.Text = "Load and Display 2d Array Method 1";
            this.BtnLoadDisplay.UseVisualStyleBackColor = true;
            this.BtnLoadDisplay.Click += new System.EventHandler(this.BtnLoadDisplay_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(43, 99);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(211, 139);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnLoadDisplayNew
            // 
            this.BtnLoadDisplayNew.Location = new System.Drawing.Point(159, 12);
            this.BtnLoadDisplayNew.Name = "BtnLoadDisplayNew";
            this.BtnLoadDisplayNew.Size = new System.Drawing.Size(105, 47);
            this.BtnLoadDisplayNew.TabIndex = 2;
            this.BtnLoadDisplayNew.Text = "Load and Display 2d Array Method 2";
            this.BtnLoadDisplayNew.UseVisualStyleBackColor = true;
            this.BtnLoadDisplayNew.Click += new System.EventHandler(this.BtnLoadDisplayNew_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(106, 293);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(79, 25);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmTwoDIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 320);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLoadDisplayNew);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnLoadDisplay);
            this.Name = "FrmTwoDIntro";
            this.Text = "Two D Arrays Intro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadDisplay;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnLoadDisplayNew;
        private System.Windows.Forms.Button BtnExit;
    }
}

