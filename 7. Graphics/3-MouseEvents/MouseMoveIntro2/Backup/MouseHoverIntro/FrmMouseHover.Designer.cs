namespace MouseHoverIntro
{
    partial class FrmMouseHover
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
            this.LblHover = new System.Windows.Forms.Label();
            this.PicOpen = new System.Windows.Forms.PictureBox();
            this.PicClosed = new System.Windows.Forms.PictureBox();
            this.LblMouseCoordinates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHover
            // 
            this.LblHover.AutoSize = true;
            this.LblHover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHover.Location = new System.Drawing.Point(42, 71);
            this.LblHover.Name = "LblHover";
            this.LblHover.Size = new System.Drawing.Size(210, 31);
            this.LblHover.TabIndex = 0;
            this.LblHover.Text = "Hover Over Me";
            this.LblHover.MouseLeave += new System.EventHandler(this.LblHover_MouseLeave);
            this.LblHover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblHover_MouseDown);
            this.LblHover.MouseHover += new System.EventHandler(this.LblHover_MouseHover);
            // 
            // PicOpen
            // 
            this.PicOpen.Image = global::MouseHoverIntro.Properties.Resources.FILES03B;
            this.PicOpen.Location = new System.Drawing.Point(120, 167);
            this.PicOpen.Name = "PicOpen";
            this.PicOpen.Size = new System.Drawing.Size(28, 31);
            this.PicOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOpen.TabIndex = 2;
            this.PicOpen.TabStop = false;
            this.PicOpen.Visible = false;
            // 
            // PicClosed
            // 
            this.PicClosed.Image = global::MouseHoverIntro.Properties.Resources.FILES03A;
            this.PicClosed.Location = new System.Drawing.Point(120, 167);
            this.PicClosed.Name = "PicClosed";
            this.PicClosed.Size = new System.Drawing.Size(28, 31);
            this.PicClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClosed.TabIndex = 1;
            this.PicClosed.TabStop = false;
            this.PicClosed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicClosed_MouseMove);
            // 
            // LblMouseCoordinates
            // 
            this.LblMouseCoordinates.AutoSize = true;
            this.LblMouseCoordinates.Location = new System.Drawing.Point(239, 233);
            this.LblMouseCoordinates.Name = "LblMouseCoordinates";
            this.LblMouseCoordinates.Size = new System.Drawing.Size(0, 13);
            this.LblMouseCoordinates.TabIndex = 4;
            // 
            // FrmMouseHover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.LblMouseCoordinates);
            this.Controls.Add(this.PicOpen);
            this.Controls.Add(this.PicClosed);
            this.Controls.Add(this.LblHover);
            this.Name = "FrmMouseHover";
            this.Text = "Mouse Hover Demo";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMouseHover_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PicOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHover;
        private System.Windows.Forms.PictureBox PicClosed;
        private System.Windows.Forms.PictureBox PicOpen;
        private System.Windows.Forms.Label LblMouseCoordinates;
    }
}

