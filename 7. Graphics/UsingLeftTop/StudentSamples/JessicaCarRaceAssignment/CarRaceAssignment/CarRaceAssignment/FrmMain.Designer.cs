namespace CarRaceAssignment
{
    partial class FrmMain
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
            this.picbcar = new System.Windows.Forms.PictureBox();
            this.picbus = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.piclight = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclight)).BeginInit();
            this.SuspendLayout();
            // 
            // picbcar
            // 
            this.picbcar.BackColor = System.Drawing.Color.Transparent;
            this.picbcar.Location = new System.Drawing.Point(-2, 55);
            this.picbcar.Name = "picbcar";
            this.picbcar.Size = new System.Drawing.Size(127, 86);
            this.picbcar.TabIndex = 0;
            this.picbcar.TabStop = false;
            // 
            // picbus
            // 
            this.picbus.BackColor = System.Drawing.Color.Transparent;
            this.picbus.Location = new System.Drawing.Point(-2, 165);
            this.picbus.Name = "picbus";
            this.picbus.Size = new System.Drawing.Size(127, 85);
            this.picbus.TabIndex = 1;
            this.picbus.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(134, 286);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // piclight
            // 
            this.piclight.BackColor = System.Drawing.Color.Transparent;
            this.piclight.Location = new System.Drawing.Point(195, 92);
            this.piclight.Name = "piclight";
            this.piclight.Size = new System.Drawing.Size(108, 95);
            this.piclight.TabIndex = 3;
            this.piclight.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(228, 286);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(318, 286);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRaceAssignment.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(497, 331);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.piclight);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picbus);
            this.Controls.Add(this.picbcar);
            this.DoubleBuffered = true;
            this.Name = "FrmMain";
            this.Text = "Car Race Assignment";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbcar;
        private System.Windows.Forms.PictureBox picbus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox piclight;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
    }
}

