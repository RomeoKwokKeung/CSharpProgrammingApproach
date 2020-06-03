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
            this.btnProblem1 = new System.Windows.Forms.Button();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.btnProblem3 = new System.Windows.Forms.Button();
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
            // btnProblem1
            // 
            this.btnProblem1.Location = new System.Drawing.Point(25, 224);
            this.btnProblem1.Name = "btnProblem1";
            this.btnProblem1.Size = new System.Drawing.Size(87, 23);
            this.btnProblem1.TabIndex = 4;
            this.btnProblem1.Text = "Count Vowels";
            this.btnProblem1.UseVisualStyleBackColor = true;
            this.btnProblem1.Click += new System.EventHandler(this.btnProblem1_Click);
            // 
            // btnProblem2
            // 
            this.btnProblem2.Location = new System.Drawing.Point(139, 224);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(87, 23);
            this.btnProblem2.TabIndex = 5;
            this.btnProblem2.Text = "Count \"the\"";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // btnProblem3
            // 
            this.btnProblem3.Location = new System.Drawing.Point(255, 224);
            this.btnProblem3.Name = "btnProblem3";
            this.btnProblem3.Size = new System.Drawing.Size(106, 23);
            this.btnProblem3.TabIndex = 6;
            this.btnProblem3.Text = "Middle char";
            this.btnProblem3.UseVisualStyleBackColor = true;
            this.btnProblem3.Click += new System.EventHandler(this.btnProblem3_Click);
            // 
            // FrmLetterCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.btnProblem3);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.btnProblem1);
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
        private System.Windows.Forms.Button btnProblem1;
        private System.Windows.Forms.Button btnProblem2;
        private System.Windows.Forms.Button btnProblem3;
    }
}

