namespace ArrayOfImagesDemo
{
    partial class FrmArrayOfImages
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
            this.BtnBegin = new System.Windows.Forms.Button();
            this.PicSign4 = new System.Windows.Forms.PictureBox();
            this.PicSign3 = new System.Windows.Forms.PictureBox();
            this.PicSign2 = new System.Windows.Forms.PictureBox();
            this.PicSign1 = new System.Windows.Forms.PictureBox();
            this.PicSign = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicSign4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBegin
            // 
            this.BtnBegin.Location = new System.Drawing.Point(134, 204);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(80, 29);
            this.BtnBegin.TabIndex = 0;
            this.BtnBegin.Text = "Start/Stop";
            this.BtnBegin.UseVisualStyleBackColor = true;
            this.BtnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // PicSign4
            // 
            this.PicSign4.Image = global::ArrayOfImagesDemo.Properties.Resources.TRFFC04;
            this.PicSign4.Location = new System.Drawing.Point(33, 179);
            this.PicSign4.Name = "PicSign4";
            this.PicSign4.Size = new System.Drawing.Size(39, 30);
            this.PicSign4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSign4.TabIndex = 4;
            this.PicSign4.TabStop = false;
            this.PicSign4.Visible = false;
            // 
            // PicSign3
            // 
            this.PicSign3.Image = global::ArrayOfImagesDemo.Properties.Resources.TRFFC03;
            this.PicSign3.Location = new System.Drawing.Point(33, 127);
            this.PicSign3.Name = "PicSign3";
            this.PicSign3.Size = new System.Drawing.Size(39, 31);
            this.PicSign3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSign3.TabIndex = 3;
            this.PicSign3.TabStop = false;
            this.PicSign3.Visible = false;
            // 
            // PicSign2
            // 
            this.PicSign2.Image = global::ArrayOfImagesDemo.Properties.Resources.TRFFC02;
            this.PicSign2.Location = new System.Drawing.Point(33, 76);
            this.PicSign2.Name = "PicSign2";
            this.PicSign2.Size = new System.Drawing.Size(39, 34);
            this.PicSign2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSign2.TabIndex = 2;
            this.PicSign2.TabStop = false;
            this.PicSign2.Visible = false;
            // 
            // PicSign1
            // 
            this.PicSign1.Image = global::ArrayOfImagesDemo.Properties.Resources.TRFFC01;
            this.PicSign1.Location = new System.Drawing.Point(33, 25);
            this.PicSign1.Name = "PicSign1";
            this.PicSign1.Size = new System.Drawing.Size(39, 35);
            this.PicSign1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSign1.TabIndex = 1;
            this.PicSign1.TabStop = false;
            this.PicSign1.Visible = false;
            // 
            // PicSign
            // 
            this.PicSign.Image = global::ArrayOfImagesDemo.Properties.Resources.TRFFC01;
            this.PicSign.Location = new System.Drawing.Point(152, 77);
            this.PicSign.Name = "PicSign";
            this.PicSign.Size = new System.Drawing.Size(36, 33);
            this.PicSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSign.TabIndex = 5;
            this.PicSign.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmArrayOfImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 262);
            this.Controls.Add(this.PicSign);
            this.Controls.Add(this.PicSign4);
            this.Controls.Add(this.PicSign3);
            this.Controls.Add(this.PicSign2);
            this.Controls.Add(this.PicSign1);
            this.Controls.Add(this.BtnBegin);
            this.Name = "FrmArrayOfImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array of Images Demo";
            this.Load += new System.EventHandler(this.FrmArrayOfImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSign4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.PictureBox PicSign1;
        private System.Windows.Forms.PictureBox PicSign2;
        private System.Windows.Forms.PictureBox PicSign3;
        private System.Windows.Forms.PictureBox PicSign4;
        private System.Windows.Forms.PictureBox PicSign;
        private System.Windows.Forms.Timer timer1;
    }
}

