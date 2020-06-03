namespace FMACatCatcher
{
    partial class frmcredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcredits));
            this.piccredits = new System.Windows.Forms.PictureBox();
            this.piced2 = new System.Windows.Forms.PictureBox();
            this.lblcredits = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piccredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piced2)).BeginInit();
            this.SuspendLayout();
            // 
            // piccredits
            // 
            this.piccredits.Image = ((System.Drawing.Image)(resources.GetObject("piccredits.Image")));
            this.piccredits.Location = new System.Drawing.Point(135, 12);
            this.piccredits.Name = "piccredits";
            this.piccredits.Size = new System.Drawing.Size(196, 62);
            this.piccredits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccredits.TabIndex = 0;
            this.piccredits.TabStop = false;
            // 
            // piced2
            // 
            this.piced2.Image = ((System.Drawing.Image)(resources.GetObject("piced2.Image")));
            this.piced2.Location = new System.Drawing.Point(12, 133);
            this.piced2.Name = "piced2";
            this.piced2.Size = new System.Drawing.Size(150, 144);
            this.piced2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piced2.TabIndex = 1;
            this.piced2.TabStop = false;
            // 
            // lblcredits
            // 
            this.lblcredits.AutoSize = true;
            this.lblcredits.Font = new System.Drawing.Font("Comic Sans MS", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcredits.ForeColor = System.Drawing.Color.Red;
            this.lblcredits.Location = new System.Drawing.Point(168, 77);
            this.lblcredits.Name = "lblcredits";
            this.lblcredits.Size = new System.Drawing.Size(248, 266);
            this.lblcredits.TabIndex = 2;
            this.lblcredits.Text = resources.GetString("lblcredits.Text");
            // 
            // btnplay
            // 
            this.btnplay.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.Firebrick;
            this.btnplay.Location = new System.Drawing.Point(294, 346);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(74, 50);
            this.btnplay.TabIndex = 3;
            this.btnplay.Text = "Play!";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.Color.Firebrick;
            this.btnreturn.Location = new System.Drawing.Point(374, 346);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(74, 50);
            this.btnreturn.TabIndex = 4;
            this.btnreturn.Text = "Return to Main Menu";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // frmcredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 408);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lblcredits);
            this.Controls.Add(this.piced2);
            this.Controls.Add(this.piccredits);
            this.Name = "frmcredits";
            this.Text = "FMA Cat Catcher!";
            ((System.ComponentModel.ISupportInitialize)(this.piccredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piced2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piccredits;
        private System.Windows.Forms.PictureBox piced2;
        private System.Windows.Forms.Label lblcredits;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnreturn;
    }
}