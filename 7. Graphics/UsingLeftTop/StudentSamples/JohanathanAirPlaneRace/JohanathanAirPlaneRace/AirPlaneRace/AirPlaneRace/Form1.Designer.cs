namespace AirPlaneRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.RedBaron = new System.Windows.Forms.PictureBox();
            this.BlueRocket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Cloud = new System.Windows.Forms.PictureBox();
            this.Cloud2 = new System.Windows.Forms.PictureBox();
            this.Cloud3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedBaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(503, 406);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(147, 70);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // RedBaron
            // 
            this.RedBaron.Location = new System.Drawing.Point(55, 58);
            this.RedBaron.Name = "RedBaron";
            this.RedBaron.Size = new System.Drawing.Size(100, 50);
            this.RedBaron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RedBaron.TabIndex = 1;
            this.RedBaron.TabStop = false;
            // 
            // BlueRocket
            // 
            this.BlueRocket.Location = new System.Drawing.Point(55, 316);
            this.BlueRocket.Name = "BlueRocket";
            this.BlueRocket.Size = new System.Drawing.Size(100, 50);
            this.BlueRocket.TabIndex = 2;
            this.BlueRocket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Cloud
            // 
            this.Cloud.Image = ((System.Drawing.Image)(resources.GetObject("Cloud.Image")));
            this.Cloud.Location = new System.Drawing.Point(803, 190);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(130, 88);
            this.Cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud.TabIndex = 3;
            this.Cloud.TabStop = false;
            this.Cloud.Visible = false;
            // 
            // Cloud2
            // 
            this.Cloud2.Image = ((System.Drawing.Image)(resources.GetObject("Cloud2.Image")));
            this.Cloud2.Location = new System.Drawing.Point(815, 38);
            this.Cloud2.Name = "Cloud2";
            this.Cloud2.Size = new System.Drawing.Size(101, 70);
            this.Cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud2.TabIndex = 4;
            this.Cloud2.TabStop = false;
            this.Cloud2.Visible = false;
            // 
            // Cloud3
            // 
            this.Cloud3.Image = ((System.Drawing.Image)(resources.GetObject("Cloud3.Image")));
            this.Cloud3.Location = new System.Drawing.Point(803, 327);
            this.Cloud3.Name = "Cloud3";
            this.Cloud3.Size = new System.Drawing.Size(122, 81);
            this.Cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud3.TabIndex = 5;
            this.Cloud3.TabStop = false;
            this.Cloud3.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(906, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cloud3);
            this.Controls.Add(this.Cloud2);
            this.Controls.Add(this.Cloud);
            this.Controls.Add(this.BlueRocket);
            this.Controls.Add(this.RedBaron);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedBaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox RedBaron;
        private System.Windows.Forms.PictureBox BlueRocket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Cloud;
        private System.Windows.Forms.PictureBox Cloud2;
        private System.Windows.Forms.PictureBox Cloud3;
        private System.Windows.Forms.Button button1;
    }
}

