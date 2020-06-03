namespace GuitarHeroClone
{
    partial class FrmDifficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDifficulty));
            this.TimTitle = new System.Windows.Forms.Timer(this.components);
            this.PicExpert1 = new System.Windows.Forms.PictureBox();
            this.PicHard1 = new System.Windows.Forms.PictureBox();
            this.PicMedium1 = new System.Windows.Forms.PictureBox();
            this.PicEasy = new System.Windows.Forms.PictureBox();
            this.PicEasy2 = new System.Windows.Forms.PictureBox();
            this.PicMedium2 = new System.Windows.Forms.PictureBox();
            this.PicHard2 = new System.Windows.Forms.PictureBox();
            this.PicExpert2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicExpert1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMedium1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEasy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMedium2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExpert2)).BeginInit();
            this.SuspendLayout();
            // 
            // TimTitle
            // 
            this.TimTitle.Enabled = true;
            this.TimTitle.Tick += new System.EventHandler(this.TimTitle_Tick);
            // 
            // PicExpert1
            // 
            this.PicExpert1.BackColor = System.Drawing.Color.Transparent;
            this.PicExpert1.Image = ((System.Drawing.Image)(resources.GetObject("PicExpert1.Image")));
            this.PicExpert1.Location = new System.Drawing.Point(347, 253);
            this.PicExpert1.Name = "PicExpert1";
            this.PicExpert1.Size = new System.Drawing.Size(147, 58);
            this.PicExpert1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicExpert1.TabIndex = 0;
            this.PicExpert1.TabStop = false;
            this.PicExpert1.Click += new System.EventHandler(this.PicExpert1_Click);
            this.PicExpert1.MouseHover += new System.EventHandler(this.PicExpert1_MouseHover);
            // 
            // PicHard1
            // 
            this.PicHard1.BackColor = System.Drawing.Color.Transparent;
            this.PicHard1.Image = ((System.Drawing.Image)(resources.GetObject("PicHard1.Image")));
            this.PicHard1.Location = new System.Drawing.Point(336, 317);
            this.PicHard1.Name = "PicHard1";
            this.PicHard1.Size = new System.Drawing.Size(110, 53);
            this.PicHard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicHard1.TabIndex = 1;
            this.PicHard1.TabStop = false;
            this.PicHard1.Click += new System.EventHandler(this.PicHard1_Click);
            this.PicHard1.MouseHover += new System.EventHandler(this.PicHard1_MouseHover);
            // 
            // PicMedium1
            // 
            this.PicMedium1.BackColor = System.Drawing.Color.Transparent;
            this.PicMedium1.Image = ((System.Drawing.Image)(resources.GetObject("PicMedium1.Image")));
            this.PicMedium1.Location = new System.Drawing.Point(327, 381);
            this.PicMedium1.Name = "PicMedium1";
            this.PicMedium1.Size = new System.Drawing.Size(169, 63);
            this.PicMedium1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicMedium1.TabIndex = 2;
            this.PicMedium1.TabStop = false;
            this.PicMedium1.Click += new System.EventHandler(this.PicMedium1_Click);
            this.PicMedium1.MouseHover += new System.EventHandler(this.PicMedium1_MouseHover);
            // 
            // PicEasy
            // 
            this.PicEasy.BackColor = System.Drawing.Color.Transparent;
            this.PicEasy.Image = ((System.Drawing.Image)(resources.GetObject("PicEasy.Image")));
            this.PicEasy.Location = new System.Drawing.Point(317, 444);
            this.PicEasy.Name = "PicEasy";
            this.PicEasy.Size = new System.Drawing.Size(108, 60);
            this.PicEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicEasy.TabIndex = 3;
            this.PicEasy.TabStop = false;
            this.PicEasy.Click += new System.EventHandler(this.PicEasy_Click);
            this.PicEasy.MouseHover += new System.EventHandler(this.PicEasy_MouseHover);
            // 
            // PicEasy2
            // 
            this.PicEasy2.BackColor = System.Drawing.Color.Transparent;
            this.PicEasy2.Image = ((System.Drawing.Image)(resources.GetObject("PicEasy2.Image")));
            this.PicEasy2.Location = new System.Drawing.Point(317, 444);
            this.PicEasy2.Name = "PicEasy2";
            this.PicEasy2.Size = new System.Drawing.Size(108, 60);
            this.PicEasy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicEasy2.TabIndex = 7;
            this.PicEasy2.TabStop = false;
            this.PicEasy2.Visible = false;
            this.PicEasy2.MouseLeave += new System.EventHandler(this.PicEasy2_MouseLeave);
            this.PicEasy2.Click += new System.EventHandler(this.PicEasy2_Click);
            // 
            // PicMedium2
            // 
            this.PicMedium2.BackColor = System.Drawing.Color.Transparent;
            this.PicMedium2.Image = ((System.Drawing.Image)(resources.GetObject("PicMedium2.Image")));
            this.PicMedium2.Location = new System.Drawing.Point(327, 381);
            this.PicMedium2.Name = "PicMedium2";
            this.PicMedium2.Size = new System.Drawing.Size(169, 63);
            this.PicMedium2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicMedium2.TabIndex = 6;
            this.PicMedium2.TabStop = false;
            this.PicMedium2.Visible = false;
            this.PicMedium2.MouseLeave += new System.EventHandler(this.PicMedium2_MouseLeave);
            this.PicMedium2.Click += new System.EventHandler(this.PicMedium2_Click);
            // 
            // PicHard2
            // 
            this.PicHard2.BackColor = System.Drawing.Color.Transparent;
            this.PicHard2.Image = ((System.Drawing.Image)(resources.GetObject("PicHard2.Image")));
            this.PicHard2.Location = new System.Drawing.Point(336, 317);
            this.PicHard2.Name = "PicHard2";
            this.PicHard2.Size = new System.Drawing.Size(110, 53);
            this.PicHard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicHard2.TabIndex = 5;
            this.PicHard2.TabStop = false;
            this.PicHard2.Visible = false;
            this.PicHard2.MouseLeave += new System.EventHandler(this.PicHard2_MouseLeave);
            this.PicHard2.Click += new System.EventHandler(this.PicHard2_Click);
            // 
            // PicExpert2
            // 
            this.PicExpert2.BackColor = System.Drawing.Color.Transparent;
            this.PicExpert2.Image = ((System.Drawing.Image)(resources.GetObject("PicExpert2.Image")));
            this.PicExpert2.Location = new System.Drawing.Point(347, 253);
            this.PicExpert2.Name = "PicExpert2";
            this.PicExpert2.Size = new System.Drawing.Size(147, 58);
            this.PicExpert2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicExpert2.TabIndex = 4;
            this.PicExpert2.TabStop = false;
            this.PicExpert2.Visible = false;
            this.PicExpert2.MouseLeave += new System.EventHandler(this.PicExpert2_MouseLeave);
            this.PicExpert2.Click += new System.EventHandler(this.PicExpert2_Click);
            // 
            // FrmDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 562);
            this.Controls.Add(this.PicEasy2);
            this.Controls.Add(this.PicMedium2);
            this.Controls.Add(this.PicHard2);
            this.Controls.Add(this.PicExpert2);
            this.Controls.Add(this.PicEasy);
            this.Controls.Add(this.PicMedium1);
            this.Controls.Add(this.PicHard1);
            this.Controls.Add(this.PicExpert1);
            this.MaximizeBox = false;
            this.Name = "FrmDifficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero of Guitar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmDifficulty_Paint);
            this.Load += new System.EventHandler(this.FrmDifficulty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicExpert1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMedium1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEasy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMedium2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExpert2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimTitle;
        private System.Windows.Forms.PictureBox PicExpert1;
        private System.Windows.Forms.PictureBox PicHard1;
        private System.Windows.Forms.PictureBox PicMedium1;
        private System.Windows.Forms.PictureBox PicEasy;
        private System.Windows.Forms.PictureBox PicEasy2;
        private System.Windows.Forms.PictureBox PicMedium2;
        private System.Windows.Forms.PictureBox PicHard2;
        private System.Windows.Forms.PictureBox PicExpert2;
    }
}