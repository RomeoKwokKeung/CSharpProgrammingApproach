namespace RandomNumbersIntro
{
    partial class FrmRandomNumberIntro
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
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnOneToSix = new System.Windows.Forms.Button();
            this.BtnSevenToTwenty = new System.Windows.Forms.Button();
            this.BtnHeadsTails = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnProblem1 = new System.Windows.Forms.Button();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.btnProblem3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRandom
            // 
            this.BtnRandom.Location = new System.Drawing.Point(27, 37);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(114, 31);
            this.BtnRandom.TabIndex = 0;
            this.BtnRandom.Text = "Generate a Random Number";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnOneToSix
            // 
            this.BtnOneToSix.Location = new System.Drawing.Point(28, 87);
            this.BtnOneToSix.Name = "BtnOneToSix";
            this.BtnOneToSix.Size = new System.Drawing.Size(78, 29);
            this.BtnOneToSix.TabIndex = 1;
            this.BtnOneToSix.Text = "1-6";
            this.BtnOneToSix.UseVisualStyleBackColor = true;
            this.BtnOneToSix.Click += new System.EventHandler(this.BtnOneToSix_Click);
            // 
            // BtnSevenToTwenty
            // 
            this.BtnSevenToTwenty.Location = new System.Drawing.Point(30, 138);
            this.BtnSevenToTwenty.Name = "BtnSevenToTwenty";
            this.BtnSevenToTwenty.Size = new System.Drawing.Size(75, 27);
            this.BtnSevenToTwenty.TabIndex = 2;
            this.BtnSevenToTwenty.Text = "7-20";
            this.BtnSevenToTwenty.UseVisualStyleBackColor = true;
            this.BtnSevenToTwenty.Click += new System.EventHandler(this.BtnSevenToTwenty_Click);
            // 
            // BtnHeadsTails
            // 
            this.BtnHeadsTails.Location = new System.Drawing.Point(31, 191);
            this.BtnHeadsTails.Name = "BtnHeadsTails";
            this.BtnHeadsTails.Size = new System.Drawing.Size(110, 28);
            this.BtnHeadsTails.TabIndex = 3;
            this.BtnHeadsTails.Text = "Heads and Tails";
            this.BtnHeadsTails.UseVisualStyleBackColor = true;
            this.BtnHeadsTails.Click += new System.EventHandler(this.BtnHeadsTails_Click);
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.Location = new System.Drawing.Point(191, 37);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(249, 173);
            this.LstDisplay.TabIndex = 4;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(240, 229);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(62, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnProblem1
            // 
            this.btnProblem1.Location = new System.Drawing.Point(31, 250);
            this.btnProblem1.Name = "btnProblem1";
            this.btnProblem1.Size = new System.Drawing.Size(75, 23);
            this.btnProblem1.TabIndex = 6;
            this.btnProblem1.Text = "Problem1";
            this.btnProblem1.UseVisualStyleBackColor = true;
            this.btnProblem1.Click += new System.EventHandler(this.btnProblem1_Click);
            // 
            // btnProblem2
            // 
            this.btnProblem2.Location = new System.Drawing.Point(31, 279);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(75, 23);
            this.btnProblem2.TabIndex = 7;
            this.btnProblem2.Text = "Problem2";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // btnProblem3
            // 
            this.btnProblem3.Location = new System.Drawing.Point(31, 308);
            this.btnProblem3.Name = "btnProblem3";
            this.btnProblem3.Size = new System.Drawing.Size(75, 23);
            this.btnProblem3.TabIndex = 8;
            this.btnProblem3.Text = "Problem3";
            this.btnProblem3.UseVisualStyleBackColor = true;
            this.btnProblem3.Click += new System.EventHandler(this.btnProblem3_Click);
            // 
            // FrmRandomNumberIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 353);
            this.Controls.Add(this.btnProblem3);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.btnProblem1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnHeadsTails);
            this.Controls.Add(this.BtnSevenToTwenty);
            this.Controls.Add(this.BtnOneToSix);
            this.Controls.Add(this.BtnRandom);
            this.Name = "FrmRandomNumberIntro";
            this.Text = "Intro to Random Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnOneToSix;
        private System.Windows.Forms.Button BtnSevenToTwenty;
        private System.Windows.Forms.Button BtnHeadsTails;
        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnProblem1;
        private System.Windows.Forms.Button btnProblem2;
        private System.Windows.Forms.Button btnProblem3;
    }
}

