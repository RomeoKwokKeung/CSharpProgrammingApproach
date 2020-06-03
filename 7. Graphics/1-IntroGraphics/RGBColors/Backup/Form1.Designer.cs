namespace RGBColors
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            this.SuspendLayout();
// 
// label1
// 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
// 
// nudRed
// 
            this.nudRed.BackColor = System.Drawing.Color.White;
            this.nudRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRed.ForeColor = System.Drawing.Color.Red;
            this.nudRed.Location = new System.Drawing.Point(41, 156);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.ReadOnly = true;
            this.nudRed.Size = new System.Drawing.Size(59, 26);
            this.nudRed.TabIndex = 2;
            this.nudRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
// 
// nudGreen
// 
            this.nudGreen.BackColor = System.Drawing.Color.White;
            this.nudGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGreen.ForeColor = System.Drawing.Color.Green;
            this.nudGreen.Location = new System.Drawing.Point(131, 156);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.ReadOnly = true;
            this.nudGreen.Size = new System.Drawing.Size(59, 26);
            this.nudGreen.TabIndex = 4;
            this.nudGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGreen.ValueChanged += new System.EventHandler(this.nudGreen_ValueChanged);
// 
// label2
// 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(106, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "G";
// 
// nudBlue
// 
            this.nudBlue.BackColor = System.Drawing.Color.White;
            this.nudBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBlue.ForeColor = System.Drawing.Color.Blue;
            this.nudBlue.Location = new System.Drawing.Point(221, 156);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.ReadOnly = true;
            this.nudBlue.Size = new System.Drawing.Size(59, 26);
            this.nudBlue.TabIndex = 6;
            this.nudBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBlue.ValueChanged += new System.EventHandler(this.nudBlue_ValueChanged);
// 
// label3
// 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(196, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
// 
// txtColor
// 
            this.txtColor.AutoSize = false;
            this.txtColor.Location = new System.Drawing.Point(10, 10);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(281, 139);
            this.txtColor.TabIndex = 7;
// 
// Form1
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.ClientSize = new System.Drawing.Size(301, 194);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Colors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
    }
}

