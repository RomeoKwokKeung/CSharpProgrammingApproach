namespace FMACatCatcher
{
    partial class frmwin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmwin));
            this.btntryagain = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntryagain
            // 
            this.btntryagain.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntryagain.ForeColor = System.Drawing.Color.Firebrick;
            this.btntryagain.Location = new System.Drawing.Point(12, 434);
            this.btntryagain.Name = "btntryagain";
            this.btntryagain.Size = new System.Drawing.Size(91, 26);
            this.btntryagain.TabIndex = 0;
            this.btntryagain.Text = "Try Again?";
            this.btntryagain.UseVisualStyleBackColor = true;
            this.btntryagain.Click += new System.EventHandler(this.btntryagain_Click);
            // 
            // btnquit
            // 
            this.btnquit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnquit.Location = new System.Drawing.Point(345, 433);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(91, 27);
            this.btnquit.TabIndex = 1;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // frmwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(448, 472);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btntryagain);
            this.Name = "frmwin";
            this.Text = "FMA Cat Catcher!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntryagain;
        private System.Windows.Forms.Button btnquit;
    }
}