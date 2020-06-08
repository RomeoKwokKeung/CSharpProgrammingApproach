namespace CardWars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lblYou = new System.Windows.Forms.Label();
            this.txtYouScore = new System.Windows.Forms.TextBox();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtCompScore = new System.Windows.Forms.TextBox();
            this.pnlComputer = new System.Windows.Forms.Panel();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.txtOver = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.picDiamond = new System.Windows.Forms.PictureBox();
            this.picClub = new System.Windows.Forms.PictureBox();
            this.picSpade = new System.Windows.Forms.PictureBox();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.pnlComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpade)).BeginInit();
            this.SuspendLayout();
// 
// lblYou
// 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(14, 13);
            this.lblYou.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(29, 17);
            this.lblYou.TabIndex = 0;
            this.lblYou.Text = "You";
// 
// txtYouScore
// 
            this.txtYouScore.BackColor = System.Drawing.Color.White;
            this.txtYouScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYouScore.Location = new System.Drawing.Point(14, 29);
            this.txtYouScore.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtYouScore.Name = "txtYouScore";
            this.txtYouScore.ReadOnly = true;
            this.txtYouScore.Size = new System.Drawing.Size(64, 26);
            this.txtYouScore.TabIndex = 1;
            this.txtYouScore.Text = "0";
            this.txtYouScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
// 
// pnlPlayer
// 
            this.pnlPlayer.BackColor = System.Drawing.Color.White;
            this.pnlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayer.Controls.Add(this.picPlayer);
            this.pnlPlayer.Controls.Add(this.lblPlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(93, 13);
            this.pnlPlayer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(98, 119);
            this.pnlPlayer.TabIndex = 2;
// 
// picPlayer
// 
            this.picPlayer.Location = new System.Drawing.Point(23, 15);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(53, 47);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
// 
// lblPlayer
// 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(32, 82);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 0);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
// 
// lblComp
// 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(14, 144);
            this.lblComp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(64, 17);
            this.lblComp.TabIndex = 3;
            this.lblComp.Text = "Computer";
// 
// txtCompScore
// 
            this.txtCompScore.BackColor = System.Drawing.Color.White;
            this.txtCompScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompScore.Location = new System.Drawing.Point(14, 160);
            this.txtCompScore.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtCompScore.Name = "txtCompScore";
            this.txtCompScore.ReadOnly = true;
            this.txtCompScore.Size = new System.Drawing.Size(64, 26);
            this.txtCompScore.TabIndex = 4;
            this.txtCompScore.Text = "0";
            this.txtCompScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
// 
// pnlComputer
// 
            this.pnlComputer.BackColor = System.Drawing.Color.White;
            this.pnlComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputer.Controls.Add(this.picComputer);
            this.pnlComputer.Controls.Add(this.lblComputer);
            this.pnlComputer.Location = new System.Drawing.Point(93, 144);
            this.pnlComputer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.pnlComputer.Name = "pnlComputer";
            this.pnlComputer.Size = new System.Drawing.Size(98, 119);
            this.pnlComputer.TabIndex = 5;
// 
// picComputer
// 
            this.picComputer.Location = new System.Drawing.Point(23, 15);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(53, 47);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputer.TabIndex = 1;
            this.picComputer.TabStop = false;
// 
// lblComputer
// 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(32, 82);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 0);
            this.lblComputer.TabIndex = 0;
            this.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
// 
// txtOver
// 
            this.txtOver.AutoSize = false;
            this.txtOver.BackColor = System.Drawing.Color.White;
            this.txtOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOver.ForeColor = System.Drawing.Color.Red;
            this.txtOver.Location = new System.Drawing.Point(210, 13);
            this.txtOver.Multiline = true;
            this.txtOver.Name = "txtOver";
            this.txtOver.ReadOnly = true;
            this.txtOver.Size = new System.Drawing.Size(100, 104);
            this.txtOver.TabIndex = 6;
            this.txtOver.Text = "Game Over";
            this.txtOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
// 
// btnNew
// 
            this.btnNew.Location = new System.Drawing.Point(213, 127);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 31);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New Game";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
// 
// btnExit
// 
            this.btnExit.Location = new System.Drawing.Point(213, 160);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
// 
// picHeart
// 
            this.picHeart.AutoSize = true;
            this.picHeart.Image = CardWars.Properties.Resources.Heart;
            this.picHeart.Location = new System.Drawing.Point(210, 198);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(16, 16);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHeart.TabIndex = 9;
            this.picHeart.TabStop = false;
            this.picHeart.Visible = false;
// 
// picDiamond
// 
            this.picDiamond.AutoSize = true;
            this.picDiamond.Image = CardWars.Properties.Resources.Diamond;
            this.picDiamond.Location = new System.Drawing.Point(271, 198);
            this.picDiamond.Name = "picDiamond";
            this.picDiamond.Size = new System.Drawing.Size(16, 16);
            this.picDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDiamond.TabIndex = 10;
            this.picDiamond.TabStop = false;
            this.picDiamond.Visible = false;
// 
// picClub
// 
            this.picClub.AutoSize = true;
            this.picClub.Image = CardWars.Properties.Resources.Club;
            this.picClub.Location = new System.Drawing.Point(210, 226);
            this.picClub.Name = "picClub";
            this.picClub.Size = new System.Drawing.Size(16, 16);
            this.picClub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClub.TabIndex = 11;
            this.picClub.TabStop = false;
            this.picClub.Visible = false;
// 
// picSpade
// 
            this.picSpade.AutoSize = true;
            this.picSpade.Image = CardWars.Properties.Resources.Spade;
            this.picSpade.Location = new System.Drawing.Point(271, 226);
            this.picSpade.Name = "picSpade";
            this.picSpade.Size = new System.Drawing.Size(16, 16);
            this.picSpade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSpade.TabIndex = 12;
            this.picSpade.TabStop = false;
            this.picSpade.Visible = false;
// 
// Form1
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.ClientSize = new System.Drawing.Size(322, 275);
            this.Controls.Add(this.picSpade);
            this.Controls.Add(this.picClub);
            this.Controls.Add(this.picDiamond);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtOver);
            this.Controls.Add(this.pnlComputer);
            this.Controls.Add(this.txtCompScore);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.txtYouScore);
            this.Controls.Add(this.lblYou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Wars";
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.pnlComputer.ResumeLayout(false);
            this.pnlComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.TextBox txtYouScore;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.TextBox txtCompScore;
        private System.Windows.Forms.Panel pnlComputer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.TextBox txtOver;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.PictureBox picDiamond;
        private System.Windows.Forms.PictureBox picClub;
        private System.Windows.Forms.PictureBox picSpade;
    }
}

