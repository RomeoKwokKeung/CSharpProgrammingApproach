namespace Animation1
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.BtnHowto = new System.Windows.Forms.Button();
            this.BtnRace = new System.Windows.Forms.Button();
            this.BtnDeveloper = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PicMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHowto
            // 
            this.BtnHowto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnHowto.Location = new System.Drawing.Point(319, 12);
            this.BtnHowto.Name = "BtnHowto";
            this.BtnHowto.Size = new System.Drawing.Size(107, 38);
            this.BtnHowto.TabIndex = 1;
            this.BtnHowto.Text = "How to Play?";
            this.BtnHowto.UseVisualStyleBackColor = false;
            this.BtnHowto.Click += new System.EventHandler(this.BtnHowto_Click);
            // 
            // BtnRace
            // 
            this.BtnRace.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRace.Location = new System.Drawing.Point(319, 65);
            this.BtnRace.Name = "BtnRace";
            this.BtnRace.Size = new System.Drawing.Size(107, 38);
            this.BtnRace.TabIndex = 2;
            this.BtnRace.Text = "RACE!";
            this.BtnRace.UseVisualStyleBackColor = false;
            this.BtnRace.Click += new System.EventHandler(this.BtnRace_Click);
            // 
            // BtnDeveloper
            // 
            this.BtnDeveloper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnDeveloper.Location = new System.Drawing.Point(319, 119);
            this.BtnDeveloper.Name = "BtnDeveloper";
            this.BtnDeveloper.Size = new System.Drawing.Size(107, 38);
            this.BtnDeveloper.TabIndex = 3;
            this.BtnDeveloper.Text = "Developer";
            this.BtnDeveloper.UseVisualStyleBackColor = false;
            this.BtnDeveloper.Click += new System.EventHandler(this.BtnDeveloper_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnExit.Location = new System.Drawing.Point(360, 261);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 24);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PicMenu
            // 
            this.PicMenu.Image = ((System.Drawing.Image)(resources.GetObject("PicMenu.Image")));
            this.PicMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicMenu.InitialImage")));
            this.PicMenu.Location = new System.Drawing.Point(0, 0);
            this.PicMenu.Name = "PicMenu";
            this.PicMenu.Size = new System.Drawing.Size(300, 300);
            this.PicMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicMenu.TabIndex = 0;
            this.PicMenu.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(447, 297);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDeveloper);
            this.Controls.Add(this.BtnRace);
            this.Controls.Add(this.BtnHowto);
            this.Controls.Add(this.PicMenu);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pro Street";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicMenu;
        private System.Windows.Forms.Button BtnHowto;
        private System.Windows.Forms.Button BtnRace;
        private System.Windows.Forms.Button BtnDeveloper;
        private System.Windows.Forms.Button BtnExit;
    }
}