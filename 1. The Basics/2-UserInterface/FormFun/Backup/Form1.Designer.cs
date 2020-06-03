namespace FormFun
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
            this.btnShrink = new System.Windows.Forms.Button();
            this.btnGrow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShrink
            // 
            this.btnShrink.Location = new System.Drawing.Point(8, 12);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(124, 35);
            this.btnShrink.TabIndex = 0;
            this.btnShrink.Text = "Shrink Form";
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // btnGrow
            // 
            this.btnGrow.Location = new System.Drawing.Point(8, 54);
            this.btnGrow.Name = "btnGrow";
            this.btnGrow.Size = new System.Drawing.Size(124, 35);
            this.btnGrow.TabIndex = 1;
            this.btnGrow.Text = "Grow Form";
            this.btnGrow.Click += new System.EventHandler(this.btnGrow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(8, 96);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(124, 35);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide Buttons";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(139, 13);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(124, 35);
            this.btnRed.TabIndex = 3;
            this.btnRed.Text = "Red Form";
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(139, 55);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(124, 35);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.Text = "Blue Form";
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(139, 97);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 35);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Buttons";
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::FormFun.Properties.Resources.prefects;
            this.ClientSize = new System.Drawing.Size(274, 142);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnGrow);
            this.Controls.Add(this.btnShrink);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Fun";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.Button btnGrow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnShow;
    }
}

