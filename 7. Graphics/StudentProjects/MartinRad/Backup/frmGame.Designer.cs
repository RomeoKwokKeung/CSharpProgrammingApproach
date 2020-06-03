namespace BeachBalls
{
    partial class frmGame
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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picScoreFinal = new System.Windows.Forms.PictureBox();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timBalls = new System.Windows.Forms.Timer(this.components);
            this.timGame = new System.Windows.Forms.Timer(this.components);
            this.timDribbler = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.timStall = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.picScore = new System.Windows.Forms.PictureBox();
            this.lblFinalScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picScoreFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGame.Location = new System.Drawing.Point(12, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(483, 502);
            this.pnlGame.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(142, 194);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 23);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Your Final Score Is:";
            this.lblTitle.Visible = false;
            // 
            // picScoreFinal
            // 
            this.picScoreFinal.Image = global::BeachBalls.Properties.Resources.GH___Score;
            this.picScoreFinal.Location = new System.Drawing.Point(146, 242);
            this.picScoreFinal.Name = "picScoreFinal";
            this.picScoreFinal.Size = new System.Drawing.Size(145, 170);
            this.picScoreFinal.TabIndex = 12;
            this.picScoreFinal.TabStop = false;
            this.picScoreFinal.Visible = false;
            // 
            // picGameOver
            // 
            this.picGameOver.Image = global::BeachBalls.Properties.Resources.Game_Over;
            this.picGameOver.Location = new System.Drawing.Point(23, 36);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(485, 155);
            this.picGameOver.TabIndex = 11;
            this.picGameOver.TabStop = false;
            this.picGameOver.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(489, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(489, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Gray;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Blue;
            this.txtTime.Location = new System.Drawing.Point(508, 166);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTime.Size = new System.Drawing.Size(100, 35);
            this.txtTime.TabIndex = 7;
            this.txtTime.TabStop = false;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(514, 142);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 23);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time Left";
            // 
            // timTime
            // 
            this.timTime.Interval = 1000;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // timStall
            // 
            this.timStall.Interval = 300;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Lime;
            this.lblScore.Location = new System.Drawing.Point(611, 294);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 21);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            // 
            // picScore
            // 
            this.picScore.Image = global::BeachBalls.Properties.Resources.GH___Score;
            this.picScore.Location = new System.Drawing.Point(489, 285);
            this.picScore.Name = "picScore";
            this.picScore.Size = new System.Drawing.Size(145, 170);
            this.picScore.TabIndex = 8;
            this.picScore.TabStop = false;
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.Color.Lime;
            this.lblFinalScore.Location = new System.Drawing.Point(272, 218);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(19, 21);
            this.lblFinalScore.TabIndex = 15;
            this.lblFinalScore.Text = "0";
            this.lblFinalScore.Visible = false;
            // 
            // frmGame
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 528);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.picGameOver);
            this.Controls.Add(this.picScoreFinal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picScore);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guitar Hero Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScoreFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timBalls;
        private System.Windows.Forms.Timer timGame;
        private System.Windows.Forms.Timer timDribbler;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timTime;
        private System.Windows.Forms.Timer timStall;
        private System.Windows.Forms.PictureBox picScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.PictureBox picScoreFinal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFinalScore;
    }
}

