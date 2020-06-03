namespace FINAL_GAME
{
    partial class FrmMain
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
            this.BtnBegin = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnInstruct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBegin
            // 
            this.BtnBegin.Location = new System.Drawing.Point(249, 164);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(75, 23);
            this.BtnBegin.TabIndex = 0;
            this.BtnBegin.Text = "Begin";
            this.BtnBegin.UseVisualStyleBackColor = true;
            this.BtnBegin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(176, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(242, 39);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Red vs Green";
            // 
            // BtnInstruct
            // 
            this.BtnInstruct.Location = new System.Drawing.Point(249, 193);
            this.BtnInstruct.Name = "BtnInstruct";
            this.BtnInstruct.Size = new System.Drawing.Size(75, 23);
            this.BtnInstruct.TabIndex = 2;
            this.BtnInstruct.Text = "Instructions";
            this.BtnInstruct.UseVisualStyleBackColor = true;
            this.BtnInstruct.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 403);
            this.Controls.Add(this.BtnInstruct);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnBegin);
            this.Name = "FrmMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnInstruct;
    }
}