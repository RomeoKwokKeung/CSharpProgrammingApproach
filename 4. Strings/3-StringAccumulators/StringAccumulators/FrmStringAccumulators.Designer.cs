namespace StringAccumulators
{
    partial class FrmStringAccumulators
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
            this.BtnConcat = new System.Windows.Forms.Button();
            this.BtnApplication = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.btnProblem3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConcat
            // 
            this.BtnConcat.Location = new System.Drawing.Point(25, 18);
            this.BtnConcat.Name = "BtnConcat";
            this.BtnConcat.Size = new System.Drawing.Size(111, 27);
            this.BtnConcat.TabIndex = 0;
            this.BtnConcat.Text = "String Acumulator";
            this.BtnConcat.UseVisualStyleBackColor = true;
            this.BtnConcat.Click += new System.EventHandler(this.BtnConcat_Click);
            // 
            // BtnApplication
            // 
            this.BtnApplication.Location = new System.Drawing.Point(25, 82);
            this.BtnApplication.Name = "BtnApplication";
            this.BtnApplication.Size = new System.Drawing.Size(110, 31);
            this.BtnApplication.TabIndex = 1;
            this.BtnApplication.Text = "Application";
            this.BtnApplication.UseVisualStyleBackColor = true;
            this.BtnApplication.Click += new System.EventHandler(this.BtnApplication_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(203, 37);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(172, 183);
            this.TxtResult.TabIndex = 2;
            // 
            // btnProblem2
            // 
            this.btnProblem2.Location = new System.Drawing.Point(26, 151);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(110, 31);
            this.btnProblem2.TabIndex = 3;
            this.btnProblem2.Text = "Six Digital Number";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // btnProblem3
            // 
            this.btnProblem3.Location = new System.Drawing.Point(26, 219);
            this.btnProblem3.Name = "btnProblem3";
            this.btnProblem3.Size = new System.Drawing.Size(110, 31);
            this.btnProblem3.TabIndex = 4;
            this.btnProblem3.Text = "Divide by 7";
            this.btnProblem3.UseVisualStyleBackColor = true;
            this.btnProblem3.Click += new System.EventHandler(this.btnProblem3_Click);
            // 
            // FrmStringAccumulators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.btnProblem3);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnApplication);
            this.Controls.Add(this.BtnConcat);
            this.Name = "FrmStringAccumulators";
            this.Text = "String Accumulators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConcat;
        private System.Windows.Forms.Button BtnApplication;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button btnProblem2;
        private System.Windows.Forms.Button btnProblem3;
    }
}

