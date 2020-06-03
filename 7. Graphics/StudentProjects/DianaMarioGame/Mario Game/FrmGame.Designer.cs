namespace Mario_Game
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.tmrMario = new System.Windows.Forms.Timer(this.components);
            this.tmrCoin = new System.Windows.Forms.Timer(this.components);
            this.tmrGoopa = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrFlame = new System.Windows.Forms.Timer(this.components);
            this.tmrtime = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.PicHelp = new System.Windows.Forms.PictureBox();
            this.tmrBlock = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMario
            // 
            this.tmrMario.Tick += new System.EventHandler(this.tmrMario_Tick);
            // 
            // tmrCoin
            // 
            this.tmrCoin.Tick += new System.EventHandler(this.tmrCoin_Tick);
            // 
            // tmrGoopa
            // 
            this.tmrGoopa.Interval = 150;
            this.tmrGoopa.Tick += new System.EventHandler(this.tmrGoopa_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(431, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(45, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrFlame
            // 
            this.tmrFlame.Tick += new System.EventHandler(this.tmrFlame_Tick);
            // 
            // tmrtime
            // 
            this.tmrtime.Interval = 1000;
            this.tmrtime.Tick += new System.EventHandler(this.tmrtime_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(431, 51);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // PicHelp
            // 
            this.PicHelp.BackColor = System.Drawing.Color.Transparent;
            this.PicHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicHelp.BackgroundImage")));
            this.PicHelp.Location = new System.Drawing.Point(-2, -3);
            this.PicHelp.Name = "PicHelp";
            this.PicHelp.Size = new System.Drawing.Size(497, 220);
            this.PicHelp.TabIndex = 3;
            this.PicHelp.TabStop = false;
            this.PicHelp.Visible = false;
            // 
            // tmrBlock
            // 
            this.tmrBlock.Tick += new System.EventHandler(this.tmrBlock_Tick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(153, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 21);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Please Enter Your Name";
            this.txtName.Visible = false;
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(201, 100);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 5;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Visible = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lblOver
            // 
            this.lblOver.AutoSize = true;
            this.lblOver.BackColor = System.Drawing.Color.Transparent;
            this.lblOver.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOver.Location = new System.Drawing.Point(42, 135);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(412, 73);
            this.lblOver.TabIndex = 6;
            this.lblOver.Text = "Game Over!";
            this.lblOver.Visible = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 217);
            this.Controls.Add(this.lblOver);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.PicHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FrmGame";
            this.Text = "Diana\'s Mario World";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGame_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMario;
        private System.Windows.Forms.Timer tmrCoin;
        private System.Windows.Forms.Timer tmrGoopa;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrFlame;
        private System.Windows.Forms.Timer tmrtime;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox PicHelp;
        private System.Windows.Forms.Timer tmrBlock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label lblOver;
    }
}