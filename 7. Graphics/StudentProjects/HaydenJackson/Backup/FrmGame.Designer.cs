namespace FrmIntro
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            this.TimFishOne = new System.Windows.Forms.Timer(this.components);
            this.TimFishTwo = new System.Windows.Forms.Timer(this.components);
            this.TimTorpedo = new System.Windows.Forms.Timer(this.components);
            this.TimDeadLeft = new System.Windows.Forms.Timer(this.components);
            this.TimDeadRight = new System.Windows.Forms.Timer(this.components);
            this.LblHow = new System.Windows.Forms.Label();
            this.LblPoints = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.TimTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimFishOne
            // 
            this.TimFishOne.Tick += new System.EventHandler(this.TimFishOne_Tick);
            // 
            // TimFishTwo
            // 
            this.TimFishTwo.Tick += new System.EventHandler(this.TimFishTwo_Tick);
            // 
            // TimTorpedo
            // 
            this.TimTorpedo.Tick += new System.EventHandler(this.TimTorpedo_Tick);
            // 
            // TimDeadLeft
            // 
            this.TimDeadLeft.Tick += new System.EventHandler(this.TimDeadLeft_Tick);
            // 
            // TimDeadRight
            // 
            this.TimDeadRight.Tick += new System.EventHandler(this.TimDeadRight_Tick);
            // 
            // LblHow
            // 
            this.LblHow.AutoSize = true;
            this.LblHow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHow.ForeColor = System.Drawing.Color.White;
            this.LblHow.Location = new System.Drawing.Point(198, 353);
            this.LblHow.Name = "LblHow";
            this.LblHow.Size = new System.Drawing.Size(99, 14);
            this.LblHow.TabIndex = 0;
            this.LblHow.Text = "Hit Enter to Start!";
            // 
            // LblPoints
            // 
            this.LblPoints.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoints.ForeColor = System.Drawing.Color.White;
            this.LblPoints.Location = new System.Drawing.Point(12, 353);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(167, 13);
            this.LblPoints.TabIndex = 1;
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.White;
            this.LblTime.Location = new System.Drawing.Point(333, 353);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(167, 13);
            this.LblTime.TabIndex = 2;
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TimTime
            // 
            this.TimTime.Interval = 1000;
            this.TimTime.Tick += new System.EventHandler(this.TimTime_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(512, 376);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.LblHow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fish Bomber";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimFishOne;
        private System.Windows.Forms.Timer TimFishTwo;
        private System.Windows.Forms.Timer TimTorpedo;
        private System.Windows.Forms.Timer TimDeadLeft;
        private System.Windows.Forms.Timer TimDeadRight;
        private System.Windows.Forms.Label LblHow;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer TimTime;
    }
}