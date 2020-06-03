namespace GuitarHeroClone
{
    partial class FrmHighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHighScores));
            this.PicReturnFromAbout = new System.Windows.Forms.PictureBox();
            this.LstExpert = new System.Windows.Forms.ListBox();
            this.LstHard = new System.Windows.Forms.ListBox();
            this.LstEasy = new System.Windows.Forms.ListBox();
            this.LstMedium = new System.Windows.Forms.ListBox();
            this.LblEasyTitle = new System.Windows.Forms.Label();
            this.LblMediumTitle = new System.Windows.Forms.Label();
            this.LblHardTitle = new System.Windows.Forms.Label();
            this.LblExpertTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnFromAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // PicReturnFromAbout
            // 
            this.PicReturnFromAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicReturnFromAbout.Image = ((System.Drawing.Image)(resources.GetObject("PicReturnFromAbout.Image")));
            this.PicReturnFromAbout.Location = new System.Drawing.Point(641, 481);
            this.PicReturnFromAbout.Name = "PicReturnFromAbout";
            this.PicReturnFromAbout.Size = new System.Drawing.Size(83, 22);
            this.PicReturnFromAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicReturnFromAbout.TabIndex = 1;
            this.PicReturnFromAbout.TabStop = false;
            this.PicReturnFromAbout.Click += new System.EventHandler(this.PicReturnFromAbout_Click);
            // 
            // LstExpert
            // 
            this.LstExpert.BackColor = System.Drawing.Color.Black;
            this.LstExpert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstExpert.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstExpert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LstExpert.FormattingEnabled = true;
            this.LstExpert.Location = new System.Drawing.Point(213, 353);
            this.LstExpert.Name = "LstExpert";
            this.LstExpert.Size = new System.Drawing.Size(189, 143);
            this.LstExpert.TabIndex = 2;
            // 
            // LstHard
            // 
            this.LstHard.BackColor = System.Drawing.Color.Black;
            this.LstHard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstHard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstHard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LstHard.FormattingEnabled = true;
            this.LstHard.Location = new System.Drawing.Point(446, 353);
            this.LstHard.Name = "LstHard";
            this.LstHard.Size = new System.Drawing.Size(189, 143);
            this.LstHard.TabIndex = 3;
            // 
            // LstEasy
            // 
            this.LstEasy.BackColor = System.Drawing.Color.Black;
            this.LstEasy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstEasy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LstEasy.FormattingEnabled = true;
            this.LstEasy.Location = new System.Drawing.Point(213, 181);
            this.LstEasy.Name = "LstEasy";
            this.LstEasy.Size = new System.Drawing.Size(189, 143);
            this.LstEasy.TabIndex = 5;
            // 
            // LstMedium
            // 
            this.LstMedium.BackColor = System.Drawing.Color.Black;
            this.LstMedium.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstMedium.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstMedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LstMedium.FormattingEnabled = true;
            this.LstMedium.Location = new System.Drawing.Point(446, 181);
            this.LstMedium.Name = "LstMedium";
            this.LstMedium.Size = new System.Drawing.Size(189, 143);
            this.LstMedium.TabIndex = 4;
            // 
            // LblEasyTitle
            // 
            this.LblEasyTitle.AutoSize = true;
            this.LblEasyTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblEasyTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEasyTitle.ForeColor = System.Drawing.Color.White;
            this.LblEasyTitle.Location = new System.Drawing.Point(210, 162);
            this.LblEasyTitle.Name = "LblEasyTitle";
            this.LblEasyTitle.Size = new System.Drawing.Size(99, 16);
            this.LblEasyTitle.TabIndex = 7;
            this.LblEasyTitle.Text = "Easy Difficulty";
            // 
            // LblMediumTitle
            // 
            this.LblMediumTitle.AutoSize = true;
            this.LblMediumTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblMediumTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMediumTitle.ForeColor = System.Drawing.Color.White;
            this.LblMediumTitle.Location = new System.Drawing.Point(443, 162);
            this.LblMediumTitle.Name = "LblMediumTitle";
            this.LblMediumTitle.Size = new System.Drawing.Size(118, 16);
            this.LblMediumTitle.TabIndex = 8;
            this.LblMediumTitle.Text = "Medium Difficulty";
            // 
            // LblHardTitle
            // 
            this.LblHardTitle.AutoSize = true;
            this.LblHardTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblHardTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHardTitle.ForeColor = System.Drawing.Color.White;
            this.LblHardTitle.Location = new System.Drawing.Point(210, 334);
            this.LblHardTitle.Name = "LblHardTitle";
            this.LblHardTitle.Size = new System.Drawing.Size(100, 16);
            this.LblHardTitle.TabIndex = 9;
            this.LblHardTitle.Text = "Hard Difficulty";
            // 
            // LblExpertTitle
            // 
            this.LblExpertTitle.AutoSize = true;
            this.LblExpertTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblExpertTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExpertTitle.ForeColor = System.Drawing.Color.White;
            this.LblExpertTitle.Location = new System.Drawing.Point(443, 334);
            this.LblExpertTitle.Name = "LblExpertTitle";
            this.LblExpertTitle.Size = new System.Drawing.Size(111, 16);
            this.LblExpertTitle.TabIndex = 10;
            this.LblExpertTitle.Text = "Expert Difficulty";
            // 
            // FrmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 562);
            this.Controls.Add(this.LblExpertTitle);
            this.Controls.Add(this.LblHardTitle);
            this.Controls.Add(this.LblMediumTitle);
            this.Controls.Add(this.LblEasyTitle);
            this.Controls.Add(this.LstEasy);
            this.Controls.Add(this.LstMedium);
            this.Controls.Add(this.LstHard);
            this.Controls.Add(this.LstExpert);
            this.Controls.Add(this.PicReturnFromAbout);
            this.MaximizeBox = false;
            this.Name = "FrmHighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero of Guitar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmHighScores_Paint);
            this.Load += new System.EventHandler(this.FrmHighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicReturnFromAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicReturnFromAbout;
        private System.Windows.Forms.ListBox LstExpert;
        private System.Windows.Forms.ListBox LstHard;
        private System.Windows.Forms.ListBox LstEasy;
        private System.Windows.Forms.ListBox LstMedium;
        private System.Windows.Forms.Label LblEasyTitle;
        private System.Windows.Forms.Label LblMediumTitle;
        private System.Windows.Forms.Label LblHardTitle;
        private System.Windows.Forms.Label LblExpertTitle;
    }
}