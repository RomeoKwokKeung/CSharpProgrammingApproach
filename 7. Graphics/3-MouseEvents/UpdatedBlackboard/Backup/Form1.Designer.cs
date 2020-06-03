namespace Blackboard
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
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.rdoMagenta = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoCyan = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGray = new System.Windows.Forms.RadioButton();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBlackboard = new System.Windows.Forms.Panel();
            this.nudPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CboBackground = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.Color.Black;
            this.grpColor.Controls.Add(this.rdoWhite);
            this.grpColor.Controls.Add(this.rdoYellow);
            this.grpColor.Controls.Add(this.rdoMagenta);
            this.grpColor.Controls.Add(this.rdoRed);
            this.grpColor.Controls.Add(this.rdoCyan);
            this.grpColor.Controls.Add(this.rdoGreen);
            this.grpColor.Controls.Add(this.rdoBlue);
            this.grpColor.Controls.Add(this.rdoGray);
            this.grpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.ForeColor = System.Drawing.Color.White;
            this.grpColor.Location = new System.Drawing.Point(493, 10);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(120, 224);
            this.grpColor.TabIndex = 0;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Location = new System.Drawing.Point(16, 188);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(86, 20);
            this.rdoWhite.TabIndex = 7;
            this.rdoWhite.Text = "               ";
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(16, 166);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(86, 20);
            this.rdoYellow.TabIndex = 6;
            this.rdoYellow.Text = "               ";
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // rdoMagenta
            // 
            this.rdoMagenta.AutoSize = true;
            this.rdoMagenta.Location = new System.Drawing.Point(16, 142);
            this.rdoMagenta.Name = "rdoMagenta";
            this.rdoMagenta.Size = new System.Drawing.Size(86, 20);
            this.rdoMagenta.TabIndex = 5;
            this.rdoMagenta.Text = "               ";
            this.rdoMagenta.CheckedChanged += new System.EventHandler(this.rdoMagenta_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(16, 118);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(86, 20);
            this.rdoRed.TabIndex = 4;
            this.rdoRed.Text = "               ";
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoCyan
            // 
            this.rdoCyan.AutoSize = true;
            this.rdoCyan.Location = new System.Drawing.Point(16, 94);
            this.rdoCyan.Name = "rdoCyan";
            this.rdoCyan.Size = new System.Drawing.Size(86, 20);
            this.rdoCyan.TabIndex = 3;
            this.rdoCyan.Text = "               ";
            this.rdoCyan.CheckedChanged += new System.EventHandler(this.rdoCyan_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(16, 70);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(86, 20);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.Text = "               ";
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(16, 46);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(86, 20);
            this.rdoBlue.TabIndex = 1;
            this.rdoBlue.Text = "               ";
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGray
            // 
            this.rdoGray.AutoSize = true;
            this.rdoGray.BackColor = System.Drawing.Color.Black;
            this.rdoGray.Location = new System.Drawing.Point(16, 22);
            this.rdoGray.Name = "rdoGray";
            this.rdoGray.Size = new System.Drawing.Size(86, 20);
            this.rdoGray.TabIndex = 0;
            this.rdoGray.Text = "               ";
            this.rdoGray.UseVisualStyleBackColor = false;
            this.rdoGray.CheckedChanged += new System.EventHandler(this.rdoGray_CheckedChanged);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(500, 257);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(112, 20);
            this.btnErase.TabIndex = 1;
            this.btnErase.Text = "Erase";
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBlackboard
            // 
            this.pnlBlackboard.BackColor = System.Drawing.Color.Black;
            this.pnlBlackboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBlackboard.Location = new System.Drawing.Point(10, 10);
            this.pnlBlackboard.Name = "pnlBlackboard";
            this.pnlBlackboard.Size = new System.Drawing.Size(476, 373);
            this.pnlBlackboard.TabIndex = 3;
            this.pnlBlackboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseDown);
            this.pnlBlackboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseMove);
            this.pnlBlackboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseUp);
            // 
            // nudPenWidth
            // 
            this.nudPenWidth.Location = new System.Drawing.Point(500, 336);
            this.nudPenWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPenWidth.Name = "nudPenWidth";
            this.nudPenWidth.Size = new System.Drawing.Size(30, 20);
            this.nudPenWidth.TabIndex = 4;
            this.nudPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pen Width";
            // 
            // CboBackground
            // 
            this.CboBackground.FormattingEnabled = true;
            this.CboBackground.Items.AddRange(new object[] {
            "Gray",
            "Blue",
            "Green",
            "Cyan",
            "Red",
            "Magenta",
            "Yellow",
            "White"});
            this.CboBackground.Location = new System.Drawing.Point(576, 335);
            this.CboBackground.Name = "CboBackground";
            this.CboBackground.Size = new System.Drawing.Size(81, 21);
            this.CboBackground.TabIndex = 6;
            this.CboBackground.SelectedIndexChanged += new System.EventHandler(this.CboBackground_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Background Colour";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(683, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboBackground);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPenWidth);
            this.Controls.Add(this.pnlBlackboard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.grpColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackboard Fun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton rdoGray;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoCyan;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoMagenta;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBlackboard;
        private System.Windows.Forms.NumericUpDown nudPenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboBackground;
        private System.Windows.Forms.Label label2;
    }
}

