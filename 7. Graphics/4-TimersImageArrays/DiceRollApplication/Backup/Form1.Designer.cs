namespace DiceRoll
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
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.picDots1 = new System.Windows.Forms.PictureBox();
            this.picDots2 = new System.Windows.Forms.PictureBox();
            this.picDots3 = new System.Windows.Forms.PictureBox();
            this.picDots4 = new System.Windows.Forms.PictureBox();
            this.picDots5 = new System.Windows.Forms.PictureBox();
            this.picDots6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots6)).BeginInit();
            this.SuspendLayout();
            // 
            // picDice1
            // 
            this.picDice1.Location = new System.Drawing.Point(10, 14);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(130, 130);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 0;
            this.picDice1.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.Location = new System.Drawing.Point(150, 14);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(130, 130);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 1;
            this.picDice2.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(76, 155);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(149, 27);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picDots1
            // 
            this.picDots1.Image = global::DiceRoll.Properties.Resources.DICE1;
            this.picDots1.Location = new System.Drawing.Point(14, 218);
            this.picDots1.Name = "picDots1";
            this.picDots1.Size = new System.Drawing.Size(26, 25);
            this.picDots1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots1.TabIndex = 3;
            this.picDots1.TabStop = false;
            this.picDots1.Visible = false;
            // 
            // picDots2
            // 
            this.picDots2.Image = global::DiceRoll.Properties.Resources.DICE2;
            this.picDots2.Location = new System.Drawing.Point(60, 218);
            this.picDots2.Name = "picDots2";
            this.picDots2.Size = new System.Drawing.Size(26, 25);
            this.picDots2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots2.TabIndex = 4;
            this.picDots2.TabStop = false;
            this.picDots2.Visible = false;
            // 
            // picDots3
            // 
            this.picDots3.Image = global::DiceRoll.Properties.Resources.DICE3;
            this.picDots3.Location = new System.Drawing.Point(104, 218);
            this.picDots3.Name = "picDots3";
            this.picDots3.Size = new System.Drawing.Size(26, 25);
            this.picDots3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots3.TabIndex = 5;
            this.picDots3.TabStop = false;
            this.picDots3.Visible = false;
            // 
            // picDots4
            // 
            this.picDots4.Image = global::DiceRoll.Properties.Resources.DICE4;
            this.picDots4.Location = new System.Drawing.Point(150, 218);
            this.picDots4.Name = "picDots4";
            this.picDots4.Size = new System.Drawing.Size(26, 25);
            this.picDots4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots4.TabIndex = 6;
            this.picDots4.TabStop = false;
            this.picDots4.Visible = false;
            // 
            // picDots5
            // 
            this.picDots5.Image = global::DiceRoll.Properties.Resources.DICE5;
            this.picDots5.Location = new System.Drawing.Point(199, 218);
            this.picDots5.Name = "picDots5";
            this.picDots5.Size = new System.Drawing.Size(26, 25);
            this.picDots5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots5.TabIndex = 7;
            this.picDots5.TabStop = false;
            this.picDots5.Visible = false;
            // 
            // picDots6
            // 
            this.picDots6.Image = global::DiceRoll.Properties.Resources.DICE6;
            this.picDots6.Location = new System.Drawing.Point(245, 218);
            this.picDots6.Name = "picDots6";
            this.picDots6.Size = new System.Drawing.Size(26, 25);
            this.picDots6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots6.TabIndex = 8;
            this.picDots6.TabStop = false;
            this.picDots6.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblResults
            // 
            this.LblResults.AutoSize = true;
            this.LblResults.Location = new System.Drawing.Point(109, 191);
            this.LblResults.Name = "LblResults";
            this.LblResults.Size = new System.Drawing.Size(0, 13);
            this.LblResults.TabIndex = 9;
            this.LblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(292, 255);
            this.Controls.Add(this.LblResults);
            this.Controls.Add(this.picDots6);
            this.Controls.Add(this.picDots5);
            this.Controls.Add(this.picDots4);
            this.Controls.Add(this.picDots3);
            this.Controls.Add(this.picDots2);
            this.Controls.Add(this.picDots1);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Rolling";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picDots1;
        private System.Windows.Forms.PictureBox picDots2;
        private System.Windows.Forms.PictureBox picDots3;
        private System.Windows.Forms.PictureBox picDots4;
        private System.Windows.Forms.PictureBox picDots5;
        private System.Windows.Forms.PictureBox picDots6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblResults;
    }
}

