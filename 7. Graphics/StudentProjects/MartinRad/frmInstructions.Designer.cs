namespace BeachBalls
{
    partial class frmInstructions
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
            this.lblHelp = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.lblHelp2 = new System.Windows.Forms.Label();
            this.lblHelp3 = new System.Windows.Forms.Label();
            this.lblHelp4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(12, 28);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(467, 23);
            this.lblHelp.TabIndex = 7;
            this.lblHelp.Text = "Playing this game is simple. All you have to do is press the keys";
            // 
            // picHelp
            // 
            this.picHelp.Image = global::BeachBalls.Properties.Resources.score;
            this.picHelp.Location = new System.Drawing.Point(136, 211);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(157, 158);
            this.picHelp.TabIndex = 8;
            this.picHelp.TabStop = false;
            // 
            // lblHelp2
            // 
            this.lblHelp2.AutoSize = true;
            this.lblHelp2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp2.ForeColor = System.Drawing.Color.White;
            this.lblHelp2.Location = new System.Drawing.Point(105, 68);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(209, 45);
            this.lblHelp2.TabIndex = 9;
            this.lblHelp2.Text = "C, V, B, N, M";
            // 
            // lblHelp3
            // 
            this.lblHelp3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp3.ForeColor = System.Drawing.Color.White;
            this.lblHelp3.Location = new System.Drawing.Point(12, 127);
            this.lblHelp3.Name = "lblHelp3";
            this.lblHelp3.Size = new System.Drawing.Size(467, 53);
            this.lblHelp3.TabIndex = 10;
            this.lblHelp3.Text = "and try to time your keystrokes so you hit the corresponding frets as they come d" +
                "own the screen";
            // 
            // lblHelp4
            // 
            this.lblHelp4.AutoSize = true;
            this.lblHelp4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp4.ForeColor = System.Drawing.Color.White;
            this.lblHelp4.Location = new System.Drawing.Point(99, 185);
            this.lblHelp4.Name = "lblHelp4";
            this.lblHelp4.Size = new System.Drawing.Size(229, 23);
            this.lblHelp4.TabIndex = 11;
            this.lblHelp4.Text = "Your Score is Displayed here:";
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(506, 381);
            this.Controls.Add(this.lblHelp4);
            this.Controls.Add(this.lblHelp3);
            this.Controls.Add(this.lblHelp2);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.lblHelp);
            this.Name = "frmInstructions";
            this.Text = "Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.Label lblHelp3;
        private System.Windows.Forms.Label lblHelp4;
    }
}