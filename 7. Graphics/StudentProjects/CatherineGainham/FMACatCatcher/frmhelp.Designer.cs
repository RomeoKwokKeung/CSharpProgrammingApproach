namespace FMACatCatcher
{
    partial class frmhelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhelp));
            this.lblexplain = new System.Windows.Forms.Label();
            this.btnopenmenu = new System.Windows.Forms.Button();
            this.btnopengame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblexplain
            // 
            this.lblexplain.AutoSize = true;
            this.lblexplain.BackColor = System.Drawing.Color.Transparent;
            this.lblexplain.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexplain.Location = new System.Drawing.Point(53, 44);
            this.lblexplain.Name = "lblexplain";
            this.lblexplain.Size = new System.Drawing.Size(273, 209);
            this.lblexplain.TabIndex = 0;
            this.lblexplain.Text = resources.GetString("lblexplain.Text");
            this.lblexplain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnopenmenu
            // 
            this.btnopenmenu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopenmenu.ForeColor = System.Drawing.Color.Firebrick;
            this.btnopenmenu.Location = new System.Drawing.Point(314, 275);
            this.btnopenmenu.Name = "btnopenmenu";
            this.btnopenmenu.Size = new System.Drawing.Size(75, 45);
            this.btnopenmenu.TabIndex = 1;
            this.btnopenmenu.Text = "Return to Main Menu";
            this.btnopenmenu.UseVisualStyleBackColor = true;
            this.btnopenmenu.Click += new System.EventHandler(this.btnopenmenu_Click);
            // 
            // btnopengame
            // 
            this.btnopengame.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopengame.ForeColor = System.Drawing.Color.Firebrick;
            this.btnopengame.Location = new System.Drawing.Point(241, 275);
            this.btnopengame.Name = "btnopengame";
            this.btnopengame.Size = new System.Drawing.Size(67, 45);
            this.btnopengame.TabIndex = 2;
            this.btnopengame.Text = "Play!";
            this.btnopengame.UseVisualStyleBackColor = true;
            this.btnopengame.Click += new System.EventHandler(this.btnopengame_Click);
            // 
            // frmhelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(401, 326);
            this.Controls.Add(this.btnopengame);
            this.Controls.Add(this.btnopenmenu);
            this.Controls.Add(this.lblexplain);
            this.Name = "frmhelp";
            this.Text = "FMA Cat Catcher!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblexplain;
        private System.Windows.Forms.Button btnopenmenu;
        private System.Windows.Forms.Button btnopengame;
    }
}