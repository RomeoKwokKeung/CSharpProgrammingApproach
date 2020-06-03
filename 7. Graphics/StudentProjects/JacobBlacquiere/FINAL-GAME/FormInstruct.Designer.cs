namespace FINAL_GAME
{
    partial class FrmInstruct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstruct));
            this.LblHow = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHow
            // 
            this.LblHow.AutoSize = true;
            this.LblHow.BackColor = System.Drawing.Color.Transparent;
            this.LblHow.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHow.ForeColor = System.Drawing.Color.White;
            this.LblHow.Location = new System.Drawing.Point(202, 9);
            this.LblHow.Name = "LblHow";
            this.LblHow.Size = new System.Drawing.Size(140, 34);
            this.LblHow.TabIndex = 0;
            this.LblHow.Text = "How to Play";
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.BackColor = System.Drawing.Color.Transparent;
            this.LblText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(191, 77);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(170, 240);
            this.LblText.TabIndex = 1;
            this.LblText.Text = resources.GetString("LblText.Text");
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(231, 338);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Return";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInstruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 388);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.LblHow);
            this.Name = "FrmInstruct";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.FormInstruct_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormInstruct_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHow;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Button BtnBack;
    }
}