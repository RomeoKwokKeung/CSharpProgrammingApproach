namespace GraphicsClassIntro2
{
    partial class FrmGraphicsClassIntro2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGraphics = new System.Windows.Forms.Button();
            this.BtnGraphicsTest2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(23, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 188);
            this.panel1.TabIndex = 0;
            // 
            // BtnGraphics
            // 
            this.BtnGraphics.Location = new System.Drawing.Point(23, 213);
            this.BtnGraphics.Name = "BtnGraphics";
            this.BtnGraphics.Size = new System.Drawing.Size(95, 37);
            this.BtnGraphics.TabIndex = 1;
            this.BtnGraphics.Text = "Perform Graphics Test 1";
            this.BtnGraphics.UseVisualStyleBackColor = true;
            this.BtnGraphics.Click += new System.EventHandler(this.BtnGraphics_Click);
            // 
            // BtnGraphicsTest2
            // 
            this.BtnGraphicsTest2.Location = new System.Drawing.Point(169, 213);
            this.BtnGraphicsTest2.Name = "BtnGraphicsTest2";
            this.BtnGraphicsTest2.Size = new System.Drawing.Size(93, 36);
            this.BtnGraphicsTest2.TabIndex = 2;
            this.BtnGraphicsTest2.Text = "Perform Graphics Test 2";
            this.BtnGraphicsTest2.UseVisualStyleBackColor = true;
            this.BtnGraphicsTest2.Click += new System.EventHandler(this.BtnGraphicsTest2_Click);
            // 
            // FrmGraphicsClassIntro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnGraphicsTest2);
            this.Controls.Add(this.BtnGraphics);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGraphicsClassIntro2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics Intro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGraphicsClassIntro2_FormClosing);
            this.Load += new System.EventHandler(this.FrmGraphicsClassIntro2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGraphics;
        private System.Windows.Forms.Button BtnGraphicsTest2;
    }
}

