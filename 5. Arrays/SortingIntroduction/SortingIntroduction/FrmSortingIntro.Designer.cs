namespace SortingIntroduction
{
    partial class FrmSortingIntro
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
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnN = new System.Windows.Forms.Button();
            this.BtnBubble = new System.Windows.Forms.Button();
            this.LstInfo = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTwo
            // 
            this.BtnTwo.Location = new System.Drawing.Point(31, 40);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(94, 34);
            this.BtnTwo.TabIndex = 0;
            this.BtnTwo.Text = "Sorting Two Numbers";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Location = new System.Drawing.Point(34, 105);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(90, 39);
            this.BtnThree.TabIndex = 1;
            this.BtnThree.Text = "Sorting Three Numbers";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // BtnN
            // 
            this.BtnN.Location = new System.Drawing.Point(34, 176);
            this.BtnN.Name = "BtnN";
            this.BtnN.Size = new System.Drawing.Size(89, 40);
            this.BtnN.TabIndex = 2;
            this.BtnN.Text = "Sorting N Numbers";
            this.BtnN.UseVisualStyleBackColor = true;
            this.BtnN.Click += new System.EventHandler(this.BtnN_Click);
            // 
            // BtnBubble
            // 
            this.BtnBubble.Location = new System.Drawing.Point(35, 247);
            this.BtnBubble.Name = "BtnBubble";
            this.BtnBubble.Size = new System.Drawing.Size(87, 35);
            this.BtnBubble.TabIndex = 3;
            this.BtnBubble.Text = "The Bubble Sort";
            this.BtnBubble.UseVisualStyleBackColor = true;
            this.BtnBubble.Click += new System.EventHandler(this.BtnBubble_Click);
            // 
            // LstInfo
            // 
            this.LstInfo.FormattingEnabled = true;
            this.LstInfo.Location = new System.Drawing.Point(163, 50);
            this.LstInfo.Name = "LstInfo";
            this.LstInfo.Size = new System.Drawing.Size(199, 225);
            this.LstInfo.TabIndex = 4;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(220, 306);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(83, 27);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmSortingIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 352);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstInfo);
            this.Controls.Add(this.BtnBubble);
            this.Controls.Add(this.BtnN);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnTwo);
            this.Name = "FrmSortingIntro";
            this.Text = "Introduction to Sorting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnN;
        private System.Windows.Forms.Button BtnBubble;
        private System.Windows.Forms.ListBox LstInfo;
        private System.Windows.Forms.Button BtnExit;
    }
}

