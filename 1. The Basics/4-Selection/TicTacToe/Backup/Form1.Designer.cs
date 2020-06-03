namespace TicTacToe
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTopLeft = new System.Windows.Forms.TextBox();
            this.txtTopMiddle = new System.Windows.Forms.TextBox();
            this.txtTopRight = new System.Windows.Forms.TextBox();
            this.txtMiddleLeft = new System.Windows.Forms.TextBox();
            this.txtMiddleMiddle = new System.Windows.Forms.TextBox();
            this.txtMiddleRight = new System.Windows.Forms.TextBox();
            this.txtBottomRight = new System.Windows.Forms.TextBox();
            this.txtBottomMiddle = new System.Windows.Forms.TextBox();
            this.txtBottomLeft = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
// 
// txtMessage
// 
            this.txtMessage.AutoSize = false;
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(13, 13);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(210, 55);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TabStop = false;
            this.txtMessage.Text = "X\'s Turn";
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
// 
// textBox2
// 
            this.textBox2.AutoSize = false;
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(13, 136);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(210, 11);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
// 
// textBox3
// 
            this.textBox3.AutoSize = false;
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(13, 214);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(210, 11);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
// 
// textBox4
// 
            this.textBox4.AutoSize = false;
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(74, 75);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(11, 211);
            this.textBox4.TabIndex = 3;
            this.textBox4.TabStop = false;
// 
// textBox5
// 
            this.textBox5.AutoSize = false;
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(151, 75);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(11, 211);
            this.textBox5.TabIndex = 4;
            this.textBox5.TabStop = false;
// 
// txtTopLeft
// 
            this.txtTopLeft.AutoSize = false;
            this.txtTopLeft.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopLeft.ForeColor = System.Drawing.Color.Blue;
            this.txtTopLeft.Location = new System.Drawing.Point(13, 75);
            this.txtTopLeft.Multiline = true;
            this.txtTopLeft.Name = "txtTopLeft";
            this.txtTopLeft.ReadOnly = true;
            this.txtTopLeft.Size = new System.Drawing.Size(54, 54);
            this.txtTopLeft.TabIndex = 5;
            this.txtTopLeft.TabStop = false;
            this.txtTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTopLeft.Click += new System.EventHandler(this.txtTopLeft_Click);
            
// txtTopMiddle
// 
            this.txtTopMiddle.AutoSize = false;
            this.txtTopMiddle.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopMiddle.ForeColor = System.Drawing.Color.Blue;
            this.txtTopMiddle.Location = new System.Drawing.Point(90, 75);
            this.txtTopMiddle.Multiline = true;
            this.txtTopMiddle.Name = "txtTopMiddle";
            this.txtTopMiddle.ReadOnly = true;
            this.txtTopMiddle.Size = new System.Drawing.Size(54, 54);
            this.txtTopMiddle.TabIndex = 6;
            this.txtTopMiddle.TabStop = false;
            this.txtTopMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTopMiddle.Click += new System.EventHandler(this.txtTopMiddle_Click);
// 
// txtTopRight
// 
            this.txtTopRight.AutoSize = false;
            this.txtTopRight.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopRight.ForeColor = System.Drawing.Color.Blue;
            this.txtTopRight.Location = new System.Drawing.Point(169, 75);
            this.txtTopRight.Multiline = true;
            this.txtTopRight.Name = "txtTopRight";
            this.txtTopRight.ReadOnly = true;
            this.txtTopRight.Size = new System.Drawing.Size(54, 54);
            this.txtTopRight.TabIndex = 7;
            this.txtTopRight.TabStop = false;
            this.txtTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTopRight.Click += new System.EventHandler(this.txtTopRight_Click);
// 
// txtMiddleLeft
// 
            this.txtMiddleLeft.AutoSize = false;
            this.txtMiddleLeft.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleLeft.ForeColor = System.Drawing.Color.Blue;
            this.txtMiddleLeft.Location = new System.Drawing.Point(13, 153);
            this.txtMiddleLeft.Multiline = true;
            this.txtMiddleLeft.Name = "txtMiddleLeft";
            this.txtMiddleLeft.ReadOnly = true;
            this.txtMiddleLeft.Size = new System.Drawing.Size(54, 54);
            this.txtMiddleLeft.TabIndex = 8;
            this.txtMiddleLeft.TabStop = false;
            this.txtMiddleLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiddleLeft.Click += new System.EventHandler(this.txtMiddleLeft_Click);
// 
// txtMiddleMiddle
// 
            this.txtMiddleMiddle.AutoSize = false;
            this.txtMiddleMiddle.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleMiddle.ForeColor = System.Drawing.Color.Blue;
            this.txtMiddleMiddle.Location = new System.Drawing.Point(92, 153);
            this.txtMiddleMiddle.Multiline = true;
            this.txtMiddleMiddle.Name = "txtMiddleMiddle";
            this.txtMiddleMiddle.ReadOnly = true;
            this.txtMiddleMiddle.Size = new System.Drawing.Size(54, 54);
            this.txtMiddleMiddle.TabIndex = 9;
            this.txtMiddleMiddle.TabStop = false;
            this.txtMiddleMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiddleMiddle.Click += new System.EventHandler(this.txtMiddleMiddle_Click);
// 
// txtMiddleRight
// 
            this.txtMiddleRight.AutoSize = false;
            this.txtMiddleRight.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleRight.ForeColor = System.Drawing.Color.Blue;
            this.txtMiddleRight.Location = new System.Drawing.Point(169, 153);
            this.txtMiddleRight.Multiline = true;
            this.txtMiddleRight.Name = "txtMiddleRight";
            this.txtMiddleRight.ReadOnly = true;
            this.txtMiddleRight.Size = new System.Drawing.Size(54, 54);
            this.txtMiddleRight.TabIndex = 10;
            this.txtMiddleRight.TabStop = false;
            this.txtMiddleRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiddleRight.Click += new System.EventHandler(this.txtMiddleRight_Click);
// 
// txtBottomRight
// 
            this.txtBottomRight.AutoSize = false;
            this.txtBottomRight.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBottomRight.ForeColor = System.Drawing.Color.Blue;
            this.txtBottomRight.Location = new System.Drawing.Point(169, 232);
            this.txtBottomRight.Multiline = true;
            this.txtBottomRight.Name = "txtBottomRight";
            this.txtBottomRight.ReadOnly = true;
            this.txtBottomRight.Size = new System.Drawing.Size(54, 54);
            this.txtBottomRight.TabIndex = 13;
            this.txtBottomRight.TabStop = false;
            this.txtBottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBottomRight.Click += new System.EventHandler(this.txtBottomRight_Click);
// 
// txtBottomMiddle
// 
            this.txtBottomMiddle.AutoSize = false;
            this.txtBottomMiddle.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBottomMiddle.ForeColor = System.Drawing.Color.Blue;
            this.txtBottomMiddle.Location = new System.Drawing.Point(92, 232);
            this.txtBottomMiddle.Multiline = true;
            this.txtBottomMiddle.Name = "txtBottomMiddle";
            this.txtBottomMiddle.ReadOnly = true;
            this.txtBottomMiddle.Size = new System.Drawing.Size(54, 54);
            this.txtBottomMiddle.TabIndex = 12;
            this.txtBottomMiddle.TabStop = false;
            this.txtBottomMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBottomMiddle.Click += new System.EventHandler(this.txtBottomMiddle_Click);
// 
// txtBottomLeft
// 
            this.txtBottomLeft.AutoSize = false;
            this.txtBottomLeft.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBottomLeft.ForeColor = System.Drawing.Color.Blue;
            this.txtBottomLeft.Location = new System.Drawing.Point(13, 232);
            this.txtBottomLeft.Multiline = true;
            this.txtBottomLeft.Name = "txtBottomLeft";
            this.txtBottomLeft.ReadOnly = true;
            this.txtBottomLeft.Size = new System.Drawing.Size(54, 54);
            this.txtBottomLeft.TabIndex = 11;
            this.txtBottomLeft.TabStop = false;
            this.txtBottomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBottomLeft.Click += new System.EventHandler(this.txtBottomLeft_Click);
// 
// btnReset
// 
            this.btnReset.Location = new System.Drawing.Point(80, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset Game";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
// 
// btnMark
// 
            this.btnMark.Location = new System.Drawing.Point(80, 323);
            this.btnMark.Name = "btnMark";
            this.btnMark.TabIndex = 15;
            this.btnMark.Text = "button2";
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
// 
// Form1
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.ClientSize = new System.Drawing.Size(242, 323);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBottomRight);
            this.Controls.Add(this.txtBottomMiddle);
            this.Controls.Add(this.txtBottomLeft);
            this.Controls.Add(this.txtMiddleRight);
            this.Controls.Add(this.txtMiddleMiddle);
            this.Controls.Add(this.txtMiddleLeft);
            this.Controls.Add(this.txtTopRight);
            this.Controls.Add(this.txtTopMiddle);
            this.Controls.Add(this.txtTopLeft);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac_toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtTopLeft;
        private System.Windows.Forms.TextBox txtTopMiddle;
        private System.Windows.Forms.TextBox txtTopRight;
        private System.Windows.Forms.TextBox txtMiddleLeft;
        private System.Windows.Forms.TextBox txtMiddleMiddle;
        private System.Windows.Forms.TextBox txtMiddleRight;
        private System.Windows.Forms.TextBox txtBottomRight;
        private System.Windows.Forms.TextBox txtBottomMiddle;
        private System.Windows.Forms.TextBox txtBottomLeft;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMark;
    }
}

