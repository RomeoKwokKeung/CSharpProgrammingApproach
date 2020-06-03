namespace LetterCount
{
    partial class FrmLetterCount
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
            this.BtnNormal = new System.Windows.Forms.Button();
            this.BtnReverse = new System.Windows.Forms.Button();
            this.BtnLetterCount = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(25, 55);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(87, 33);
            this.BtnNormal.TabIndex = 0;
            this.BtnNormal.Text = "Regular";
            this.BtnNormal.UseVisualStyleBackColor = true;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnReverse
            // 
            this.BtnReverse.Location = new System.Drawing.Point(26, 110);
            this.BtnReverse.Name = "BtnReverse";
            this.BtnReverse.Size = new System.Drawing.Size(85, 31);
            this.BtnReverse.TabIndex = 1;
            this.BtnReverse.Text = "Reverse";
            this.BtnReverse.UseVisualStyleBackColor = true;
            this.BtnReverse.Click += new System.EventHandler(this.BtnReverse_Click);
            // 
            // BtnLetterCount
            // 
            this.BtnLetterCount.Location = new System.Drawing.Point(25, 161);
            this.BtnLetterCount.Name = "BtnLetterCount";
            this.BtnLetterCount.Size = new System.Drawing.Size(86, 30);
            this.BtnLetterCount.TabIndex = 2;
            this.BtnLetterCount.Text = "Letter Count";
            this.BtnLetterCount.UseVisualStyleBackColor = true;
            this.BtnLetterCount.Click += new System.EventHandler(this.BtnLetterCount_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(193, 32);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(153, 183);
            this.TxtResult.TabIndex = 3;
            // 
            // FrmLetterCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 262);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnLetterCount);
            this.Controls.Add(this.BtnReverse);
            this.Controls.Add(this.BtnNormal);
            this.Name = "FrmLetterCount";
            this.Text = "Simple String Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.Button BtnReverse;
        private System.Windows.Forms.Button BtnLetterCount;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

