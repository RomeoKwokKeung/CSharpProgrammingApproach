namespace ccpizza
{
    partial class FrmPizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoLarge = new System.Windows.Forms.RadioButton();
            this.RdoMedium = new System.Windows.Forms.RadioButton();
            this.RdoSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoDeluxe = new System.Windows.Forms.RadioButton();
            this.RdoFour = new System.Windows.Forms.RadioButton();
            this.RdoThree = new System.Windows.Forms.RadioButton();
            this.RdoTwo = new System.Windows.Forms.RadioButton();
            this.RdoOne = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChkCoupon = new System.Windows.Forms.CheckBox();
            this.ChkDelivery = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAmountDue = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnCalculateNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CC Pizzeria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoLarge);
            this.groupBox1.Controls.Add(this.RdoMedium);
            this.groupBox1.Controls.Add(this.RdoSmall);
            this.groupBox1.Location = new System.Drawing.Point(9, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // RdoLarge
            // 
            this.RdoLarge.AutoSize = true;
            this.RdoLarge.Location = new System.Drawing.Point(12, 110);
            this.RdoLarge.Name = "RdoLarge";
            this.RdoLarge.Size = new System.Drawing.Size(152, 17);
            this.RdoLarge.TabIndex = 2;
            this.RdoLarge.TabStop = true;
            this.RdoLarge.Text = "Large  8.95 + 2.00 per item";
            this.RdoLarge.UseVisualStyleBackColor = true;
            // 
            // RdoMedium
            // 
            this.RdoMedium.AutoSize = true;
            this.RdoMedium.Location = new System.Drawing.Point(11, 71);
            this.RdoMedium.Name = "RdoMedium";
            this.RdoMedium.Size = new System.Drawing.Size(162, 17);
            this.RdoMedium.TabIndex = 1;
            this.RdoMedium.TabStop = true;
            this.RdoMedium.Text = "Medium  7.25 + 1.05 per item";
            this.RdoMedium.UseVisualStyleBackColor = true;
            // 
            // RdoSmall
            // 
            this.RdoSmall.AutoSize = true;
            this.RdoSmall.Location = new System.Drawing.Point(10, 31);
            this.RdoSmall.Name = "RdoSmall";
            this.RdoSmall.Size = new System.Drawing.Size(144, 17);
            this.RdoSmall.TabIndex = 0;
            this.RdoSmall.TabStop = true;
            this.RdoSmall.Text = "Small  5.65 + .85 per item";
            this.RdoSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoDeluxe);
            this.groupBox2.Controls.Add(this.RdoFour);
            this.groupBox2.Controls.Add(this.RdoThree);
            this.groupBox2.Controls.Add(this.RdoTwo);
            this.groupBox2.Controls.Add(this.RdoOne);
            this.groupBox2.Location = new System.Drawing.Point(201, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // RdoDeluxe
            // 
            this.RdoDeluxe.AutoSize = true;
            this.RdoDeluxe.Location = new System.Drawing.Point(28, 178);
            this.RdoDeluxe.Name = "RdoDeluxe";
            this.RdoDeluxe.Size = new System.Drawing.Size(58, 17);
            this.RdoDeluxe.TabIndex = 4;
            this.RdoDeluxe.TabStop = true;
            this.RdoDeluxe.Text = "Deluxe";
            this.RdoDeluxe.UseVisualStyleBackColor = true;
            this.RdoDeluxe.CheckedChanged += new System.EventHandler(this.RdoDeluxe_CheckedChanged);
            // 
            // RdoFour
            // 
            this.RdoFour.AutoSize = true;
            this.RdoFour.Location = new System.Drawing.Point(27, 146);
            this.RdoFour.Name = "RdoFour";
            this.RdoFour.Size = new System.Drawing.Size(59, 17);
            this.RdoFour.TabIndex = 3;
            this.RdoFour.TabStop = true;
            this.RdoFour.Text = "4 Items";
            this.RdoFour.UseVisualStyleBackColor = true;
            this.RdoFour.CheckedChanged += new System.EventHandler(this.RdoFour_CheckedChanged);
            // 
            // RdoThree
            // 
            this.RdoThree.AutoSize = true;
            this.RdoThree.Location = new System.Drawing.Point(26, 105);
            this.RdoThree.Name = "RdoThree";
            this.RdoThree.Size = new System.Drawing.Size(59, 17);
            this.RdoThree.TabIndex = 2;
            this.RdoThree.TabStop = true;
            this.RdoThree.Text = "3 Items";
            this.RdoThree.UseVisualStyleBackColor = true;
            this.RdoThree.CheckedChanged += new System.EventHandler(this.RdoThree_CheckedChanged);
            // 
            // RdoTwo
            // 
            this.RdoTwo.AutoSize = true;
            this.RdoTwo.Location = new System.Drawing.Point(26, 66);
            this.RdoTwo.Name = "RdoTwo";
            this.RdoTwo.Size = new System.Drawing.Size(59, 17);
            this.RdoTwo.TabIndex = 1;
            this.RdoTwo.TabStop = true;
            this.RdoTwo.Text = "2 Items";
            this.RdoTwo.UseVisualStyleBackColor = true;
            this.RdoTwo.CheckedChanged += new System.EventHandler(this.RdoTwo_CheckedChanged);
            // 
            // RdoOne
            // 
            this.RdoOne.AutoSize = true;
            this.RdoOne.Location = new System.Drawing.Point(26, 25);
            this.RdoOne.Name = "RdoOne";
            this.RdoOne.Size = new System.Drawing.Size(54, 17);
            this.RdoOne.TabIndex = 0;
            this.RdoOne.TabStop = true;
            this.RdoOne.Text = "1 Item";
            this.RdoOne.UseVisualStyleBackColor = true;
            this.RdoOne.CheckedChanged += new System.EventHandler(this.RdoOne_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkCoupon);
            this.groupBox3.Controls.Add(this.ChkDelivery);
            this.groupBox3.Location = new System.Drawing.Point(379, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 99);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras";
            // 
            // ChkCoupon
            // 
            this.ChkCoupon.AutoSize = true;
            this.ChkCoupon.Location = new System.Drawing.Point(8, 64);
            this.ChkCoupon.Name = "ChkCoupon";
            this.ChkCoupon.Size = new System.Drawing.Size(63, 17);
            this.ChkCoupon.TabIndex = 1;
            this.ChkCoupon.Text = "Coupon";
            this.ChkCoupon.UseVisualStyleBackColor = true;
            // 
            // ChkDelivery
            // 
            this.ChkDelivery.AutoSize = true;
            this.ChkDelivery.Location = new System.Drawing.Point(8, 27);
            this.ChkDelivery.Name = "ChkDelivery";
            this.ChkDelivery.Size = new System.Drawing.Size(64, 17);
            this.ChkDelivery.TabIndex = 0;
            this.ChkDelivery.Text = "Delivery";
            this.ChkDelivery.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount Due";
            // 
            // LblAmountDue
            // 
            this.LblAmountDue.AutoSize = true;
            this.LblAmountDue.Location = new System.Drawing.Point(69, 292);
            this.LblAmountDue.Name = "LblAmountDue";
            this.LblAmountDue.Size = new System.Drawing.Size(0, 13);
            this.LblAmountDue.TabIndex = 5;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(72, 348);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(81, 24);
            this.BtnCalculate.TabIndex = 6;
            this.BtnCalculate.Text = "Calculate Amount Due";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnCalculateNew
            // 
            this.BtnCalculateNew.Location = new System.Drawing.Point(205, 346);
            this.BtnCalculateNew.Name = "BtnCalculateNew";
            this.BtnCalculateNew.Size = new System.Drawing.Size(84, 23);
            this.BtnCalculateNew.TabIndex = 7;
            this.BtnCalculateNew.Text = "New Order";
            this.BtnCalculateNew.UseVisualStyleBackColor = true;
            this.BtnCalculateNew.Click += new System.EventHandler(this.BtnCalculateNew_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(343, 347);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 23);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 384);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalculateNew);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.LblAmountDue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPizza";
            this.Text = "Advanced Selctive Processing Application";
            this.Load += new System.EventHandler(this.FrmPizza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAmountDue;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnCalculateNew;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.RadioButton RdoLarge;
        private System.Windows.Forms.RadioButton RdoMedium;
        private System.Windows.Forms.RadioButton RdoSmall;
        private System.Windows.Forms.RadioButton RdoDeluxe;
        private System.Windows.Forms.RadioButton RdoFour;
        private System.Windows.Forms.RadioButton RdoThree;
        private System.Windows.Forms.RadioButton RdoTwo;
        private System.Windows.Forms.RadioButton RdoOne;
        private System.Windows.Forms.CheckBox ChkCoupon;
        private System.Windows.Forms.CheckBox ChkDelivery;
    }
}

