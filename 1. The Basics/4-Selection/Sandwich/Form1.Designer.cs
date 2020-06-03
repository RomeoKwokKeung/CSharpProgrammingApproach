namespace Sandwich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBread = new System.Windows.Forms.GroupBox();
            this.rdoRye = new System.Windows.Forms.RadioButton();
            this.rdoWheat = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.grpMeats = new System.Windows.Forms.GroupBox();
            this.chkSalami = new System.Windows.Forms.CheckBox();
            this.chkPastrami = new System.Windows.Forms.CheckBox();
            this.chkTurkey = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkRoastBeef = new System.Windows.Forms.CheckBox();
            this.grpCheese = new System.Windows.Forms.GroupBox();
            this.rdoSwiss = new System.Windows.Forms.RadioButton();
            this.rdoAmerican = new System.Windows.Forms.RadioButton();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.grpCondiments = new System.Windows.Forms.GroupBox();
            this.chkPickles = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkMustard = new System.Windows.Forms.CheckBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBread.SuspendLayout();
            this.grpMeats.SuspendLayout();
            this.grpCheese.SuspendLayout();
            this.grpCondiments.SuspendLayout();
            this.SuspendLayout();
// 
// grpBread
// 
            this.grpBread.Controls.Add(this.rdoRye);
            this.grpBread.Controls.Add(this.rdoWheat);
            this.grpBread.Controls.Add(this.rdoWhite);
            this.grpBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBread.Location = new System.Drawing.Point(9, 10);
            this.grpBread.Name = "grpBread";
            this.grpBread.Size = new System.Drawing.Size(124, 103);
            this.grpBread.TabIndex = 0;
            this.grpBread.TabStop = false;
            this.grpBread.Text = "Bread";
// 
// rdoRye
// 
            this.rdoRye.AutoSize = true;
            this.rdoRye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRye.Location = new System.Drawing.Point(18, 73);
            this.rdoRye.Name = "rdoRye";
            this.rdoRye.Size = new System.Drawing.Size(40, 17);
            this.rdoRye.TabIndex = 2;
            this.rdoRye.Text = "Rye";
            this.rdoRye.CheckedChanged += new System.EventHandler(this.rdoRye_CheckedChanged);
// 
// rdoWheat
// 
            this.rdoWheat.AutoSize = true;
            this.rdoWheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWheat.Location = new System.Drawing.Point(18, 49);
            this.rdoWheat.Name = "rdoWheat";
            this.rdoWheat.Size = new System.Drawing.Size(53, 17);
            this.rdoWheat.TabIndex = 1;
            this.rdoWheat.Text = "Wheat";
            this.rdoWheat.CheckedChanged += new System.EventHandler(this.rdoWheat_CheckedChanged);
// 
// rdoWhite
// 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Checked = true;
            this.rdoWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWhite.Location = new System.Drawing.Point(18, 25);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(49, 17);
            this.rdoWhite.TabIndex = 0;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White";
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
// 
// grpMeats
// 
            this.grpMeats.Controls.Add(this.chkSalami);
            this.grpMeats.Controls.Add(this.chkPastrami);
            this.grpMeats.Controls.Add(this.chkTurkey);
            this.grpMeats.Controls.Add(this.chkHam);
            this.grpMeats.Controls.Add(this.chkRoastBeef);
            this.grpMeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMeats.Location = new System.Drawing.Point(13, 120);
            this.grpMeats.Name = "grpMeats";
            this.grpMeats.Size = new System.Drawing.Size(120, 154);
            this.grpMeats.TabIndex = 1;
            this.grpMeats.TabStop = false;
            this.grpMeats.Text = "Meats";
// 
// chkSalami
// 
            this.chkSalami.AutoSize = true;
            this.chkSalami.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalami.Location = new System.Drawing.Point(14, 121);
            this.chkSalami.Name = "chkSalami";
            this.chkSalami.Size = new System.Drawing.Size(53, 17);
            this.chkSalami.TabIndex = 4;
            this.chkSalami.Text = "Salami";
// 
// chkPastrami
// 
            this.chkPastrami.AutoSize = true;
            this.chkPastrami.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPastrami.Location = new System.Drawing.Point(14, 97);
            this.chkPastrami.Name = "chkPastrami";
            this.chkPastrami.Size = new System.Drawing.Size(62, 17);
            this.chkPastrami.TabIndex = 3;
            this.chkPastrami.Text = "Pastrami";
// 
// chkTurkey
// 
            this.chkTurkey.AutoSize = true;
            this.chkTurkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTurkey.Location = new System.Drawing.Point(14, 73);
            this.chkTurkey.Name = "chkTurkey";
            this.chkTurkey.Size = new System.Drawing.Size(55, 17);
            this.chkTurkey.TabIndex = 2;
            this.chkTurkey.Text = "Turkey";
// 
// chkHam
// 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(14, 49);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(44, 17);
            this.chkHam.TabIndex = 1;
            this.chkHam.Text = "Ham";
// 
// chkRoastBeef
// 
            this.chkRoastBeef.AutoSize = true;
            this.chkRoastBeef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRoastBeef.Location = new System.Drawing.Point(14, 25);
            this.chkRoastBeef.Name = "chkRoastBeef";
            this.chkRoastBeef.Size = new System.Drawing.Size(75, 17);
            this.chkRoastBeef.TabIndex = 0;
            this.chkRoastBeef.Text = "Roast Beef";
// 
// grpCheese
// 
            this.grpCheese.Controls.Add(this.rdoSwiss);
            this.grpCheese.Controls.Add(this.rdoAmerican);
            this.grpCheese.Controls.Add(this.rdoNone);
            this.grpCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheese.Location = new System.Drawing.Point(140, 10);
            this.grpCheese.Name = "grpCheese";
            this.grpCheese.Size = new System.Drawing.Size(120, 102);
            this.grpCheese.TabIndex = 2;
            this.grpCheese.TabStop = false;
            this.grpCheese.Text = "Cheese";
// 
// rdoSwiss
// 
            this.rdoSwiss.AutoSize = true;
            this.rdoSwiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSwiss.Location = new System.Drawing.Point(18, 73);
            this.rdoSwiss.Name = "rdoSwiss";
            this.rdoSwiss.Size = new System.Drawing.Size(48, 17);
            this.rdoSwiss.TabIndex = 2;
            this.rdoSwiss.Text = "Swiss";
            this.rdoSwiss.CheckedChanged += new System.EventHandler(this.rdoSwiss_CheckedChanged);
// 
// rdoAmerican
// 
            this.rdoAmerican.AutoSize = true;
            this.rdoAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAmerican.Location = new System.Drawing.Point(18, 49);
            this.rdoAmerican.Name = "rdoAmerican";
            this.rdoAmerican.Size = new System.Drawing.Size(65, 17);
            this.rdoAmerican.TabIndex = 1;
            this.rdoAmerican.Text = "American";
            this.rdoAmerican.CheckedChanged += new System.EventHandler(this.rdoAmerican_CheckedChanged);
// 
// rdoNone
// 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Checked = true;
            this.rdoNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNone.Location = new System.Drawing.Point(18, 25);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(47, 17);
            this.rdoNone.TabIndex = 0;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
// 
// grpCondiments
// 
            this.grpCondiments.Controls.Add(this.chkPickles);
            this.grpCondiments.Controls.Add(this.chkOnions);
            this.grpCondiments.Controls.Add(this.chkTomato);
            this.grpCondiments.Controls.Add(this.chkLettuce);
            this.grpCondiments.Controls.Add(this.chkMayo);
            this.grpCondiments.Controls.Add(this.chkMustard);
            this.grpCondiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCondiments.Location = new System.Drawing.Point(140, 119);
            this.grpCondiments.Name = "grpCondiments";
            this.grpCondiments.Size = new System.Drawing.Size(120, 175);
            this.grpCondiments.TabIndex = 3;
            this.grpCondiments.TabStop = false;
            this.grpCondiments.Text = "Condiments";
// 
// chkPickles
// 
            this.chkPickles.AutoSize = true;
            this.chkPickles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPickles.Location = new System.Drawing.Point(14, 145);
            this.chkPickles.Name = "chkPickles";
            this.chkPickles.Size = new System.Drawing.Size(56, 17);
            this.chkPickles.TabIndex = 10;
            this.chkPickles.Text = "Pickles";
// 
// chkOnions
// 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(14, 121);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(55, 17);
            this.chkOnions.TabIndex = 9;
            this.chkOnions.Text = "Onions";
// 
// chkTomato
// 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomato.Location = new System.Drawing.Point(14, 97);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(58, 17);
            this.chkTomato.TabIndex = 8;
            this.chkTomato.Text = "Tomato";
// 
// chkLettuce
// 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLettuce.Location = new System.Drawing.Point(14, 73);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(58, 17);
            this.chkLettuce.TabIndex = 7;
            this.chkLettuce.Text = "Lettuce";
// 
// chkMayo
// 
            this.chkMayo.AutoSize = true;
            this.chkMayo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayo.Location = new System.Drawing.Point(14, 49);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(79, 17);
            this.chkMayo.TabIndex = 6;
            this.chkMayo.Text = "Mayonnaise";
// 
// chkMustard
// 
            this.chkMustard.AutoSize = true;
            this.chkMustard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMustard.Location = new System.Drawing.Point(14, 25);
            this.chkMustard.Name = "chkMustard";
            this.chkMustard.Size = new System.Drawing.Size(60, 17);
            this.chkMustard.TabIndex = 5;
            this.chkMustard.Text = "Mustard";
// 
// lblOrder
// 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(277, 10);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(44, 17);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Order:";
// 
// txtOrder
// 
            this.txtOrder.AutoSize = false;
            this.txtOrder.Location = new System.Drawing.Point(277, 32);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrder.Size = new System.Drawing.Size(126, 152);
            this.txtOrder.TabIndex = 5;
// 
// btnOrder
// 
            this.btnOrder.Location = new System.Drawing.Point(304, 209);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
// 
// btnClear
// 
            this.btnClear.Location = new System.Drawing.Point(304, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
// 
// Form1
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 307);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.grpCondiments);
            this.Controls.Add(this.grpCheese);
            this.Controls.Add(this.grpMeats);
            this.Controls.Add(this.grpBread);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandwich Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBread.ResumeLayout(false);
            this.grpBread.PerformLayout();
            this.grpMeats.ResumeLayout(false);
            this.grpMeats.PerformLayout();
            this.grpCheese.ResumeLayout(false);
            this.grpCheese.PerformLayout();
            this.grpCondiments.ResumeLayout(false);
            this.grpCondiments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBread;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.RadioButton rdoWheat;
        private System.Windows.Forms.RadioButton rdoRye;
        private System.Windows.Forms.GroupBox grpMeats;
        private System.Windows.Forms.CheckBox chkRoastBeef;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkTurkey;
        private System.Windows.Forms.CheckBox chkPastrami;
        private System.Windows.Forms.CheckBox chkSalami;
        private System.Windows.Forms.GroupBox grpCheese;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.RadioButton rdoAmerican;
        private System.Windows.Forms.RadioButton rdoSwiss;
        private System.Windows.Forms.GroupBox grpCondiments;
        private System.Windows.Forms.CheckBox chkMustard;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkPickles;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
    }
}

