namespace BeachBalls
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
            this.components = new System.ComponentModel.Container();
            this.pnlBeachBalls = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtOver = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.timBalls = new System.Windows.Forms.Timer(this.components);
            this.timGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
// 
// pnlBeachBalls
// 
            this.pnlBeachBalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlBeachBalls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBeachBalls.Location = new System.Drawing.Point(10, 14);
            this.pnlBeachBalls.Name = "pnlBeachBalls";
            this.pnlBeachBalls.Size = new System.Drawing.Size(473, 333);
            this.pnlBeachBalls.TabIndex = 0;
// 
// lblHead
// 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(490, 14);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(87, 17);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "Balls Popped";
// 
// txtScore
// 
            this.txtScore.BackColor = System.Drawing.Color.White;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Blue;
            this.txtScore.Location = new System.Drawing.Point(497, 38);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtScore.TabIndex = 2;
            this.txtScore.TabStop = false;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
// 
// txtOver
// 
            this.txtOver.AutoSize = false;
            this.txtOver.BackColor = System.Drawing.Color.White;
            this.txtOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOver.ForeColor = System.Drawing.Color.Red;
            this.txtOver.Location = new System.Drawing.Point(497, 80);
            this.txtOver.Multiline = true;
            this.txtOver.Name = "txtOver";
            this.txtOver.ReadOnly = true;
            this.txtOver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOver.Size = new System.Drawing.Size(100, 117);
            this.txtOver.TabIndex = 3;
            this.txtOver.TabStop = false;
            this.txtOver.Text = "Game Over\r\n";
            this.txtOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
// 
// btnStart
// 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(510, 233);
            this.btnStart.Name = "btnStart";
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
// 
// btnExit
// 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(510, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
// 
// picBall
// 
            this.picBall.Image = BeachBalls.Properties.Resources.BALL;
            this.picBall.Location = new System.Drawing.Point(497, 293);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(37, 32);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 6;
            this.picBall.TabStop = false;
            this.picBall.Visible = false;
// 
// picArrow
// 
            this.picArrow.Image = BeachBalls.Properties.Resources.ARROW;
            this.picArrow.Location = new System.Drawing.Point(557, 293);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(37, 32);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 7;
            this.picArrow.TabStop = false;
            this.picArrow.Visible = false;
// 
// timBalls
// 
            this.timBalls.Tick += new System.EventHandler(this.timBalls_Tick);
// 
// timGame
// 
            this.timGame.Interval = 60000;
            this.timGame.Tick += new System.EventHandler(this.timGame_Tick);
// 
// Form1
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F); 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 354);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtOver);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.pnlBeachBalls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beach Balls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBeachBalls;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtOver;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Timer timBalls;
        private System.Windows.Forms.Timer timGame;
    }
}

