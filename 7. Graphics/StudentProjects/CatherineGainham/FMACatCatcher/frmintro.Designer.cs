namespace FMACatCatcher
{
    partial class frmintro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmintro));
            this.picfma = new System.Windows.Forms.PictureBox();
            this.pical = new System.Windows.Forms.PictureBox();
            this.picCC = new System.Windows.Forms.PictureBox();
            this.picsymbol = new System.Windows.Forms.PictureBox();
            this.btnplay = new System.Windows.Forms.Button();
            this.btninstructions = new System.Windows.Forms.Button();
            this.btncredits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picfma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // picfma
            // 
            this.picfma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picfma.BackgroundImage")));
            this.picfma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picfma.Location = new System.Drawing.Point(139, 3);
            this.picfma.Name = "picfma";
            this.picfma.Size = new System.Drawing.Size(282, 125);
            this.picfma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfma.TabIndex = 0;
            this.picfma.TabStop = false;
            // 
            // pical
            // 
            this.pical.Image = ((System.Drawing.Image)(resources.GetObject("pical.Image")));
            this.pical.Location = new System.Drawing.Point(29, 221);
            this.pical.Name = "pical";
            this.pical.Size = new System.Drawing.Size(202, 143);
            this.pical.TabIndex = 1;
            this.pical.TabStop = false;
            // 
            // picCC
            // 
            this.picCC.Image = ((System.Drawing.Image)(resources.GetObject("picCC.Image")));
            this.picCC.Location = new System.Drawing.Point(139, 125);
            this.picCC.Name = "picCC";
            this.picCC.Size = new System.Drawing.Size(286, 63);
            this.picCC.TabIndex = 2;
            this.picCC.TabStop = false;
            // 
            // picsymbol
            // 
            this.picsymbol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picsymbol.BackgroundImage")));
            this.picsymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picsymbol.Location = new System.Drawing.Point(398, 154);
            this.picsymbol.Name = "picsymbol";
            this.picsymbol.Size = new System.Drawing.Size(199, 254);
            this.picsymbol.TabIndex = 3;
            this.picsymbol.TabStop = false;
            // 
            // btnplay
            // 
            this.btnplay.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.Firebrick;
            this.btnplay.Location = new System.Drawing.Point(296, 221);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(96, 31);
            this.btnplay.TabIndex = 4;
            this.btnplay.Text = "Play!";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btninstructions
            // 
            this.btninstructions.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstructions.ForeColor = System.Drawing.Color.Firebrick;
            this.btninstructions.Location = new System.Drawing.Point(296, 278);
            this.btninstructions.Name = "btninstructions";
            this.btninstructions.Size = new System.Drawing.Size(96, 31);
            this.btninstructions.TabIndex = 5;
            this.btninstructions.Text = "Instructions";
            this.btninstructions.UseVisualStyleBackColor = true;
            this.btninstructions.Click += new System.EventHandler(this.btninstructions_Click_1);
            // 
            // btncredits
            // 
            this.btncredits.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredits.ForeColor = System.Drawing.Color.Firebrick;
            this.btncredits.Location = new System.Drawing.Point(296, 333);
            this.btncredits.Name = "btncredits";
            this.btncredits.Size = new System.Drawing.Size(96, 31);
            this.btncredits.TabIndex = 6;
            this.btncredits.Text = "Credits";
            this.btncredits.UseVisualStyleBackColor = true;
            this.btncredits.Click += new System.EventHandler(this.btncredits_Click_1);
            // 
            // frmintro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(581, 396);
            this.Controls.Add(this.btncredits);
            this.Controls.Add(this.btninstructions);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.picfma);
            this.Controls.Add(this.picCC);
            this.Controls.Add(this.pical);
            this.Controls.Add(this.picsymbol);
            this.Name = "frmintro";
            this.Text = "FMA Cat Catcher!";
            this.Load += new System.EventHandler(this.frmintro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsymbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picfma;
        private System.Windows.Forms.PictureBox pical;
        private System.Windows.Forms.PictureBox picCC;
        private System.Windows.Forms.PictureBox picsymbol;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btninstructions;
        private System.Windows.Forms.Button btncredits;
    }
}

