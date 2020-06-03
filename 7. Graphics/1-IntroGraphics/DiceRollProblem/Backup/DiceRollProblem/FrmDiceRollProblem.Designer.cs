namespace DiceRollProblem
{
    partial class FrmDiceRollProblem
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
            this.BtnDiceRoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDiceRoll
            // 
            this.BtnDiceRoll.Location = new System.Drawing.Point(113, 203);
            this.BtnDiceRoll.Name = "BtnDiceRoll";
            this.BtnDiceRoll.Size = new System.Drawing.Size(72, 27);
            this.BtnDiceRoll.TabIndex = 0;
            this.BtnDiceRoll.Text = "Roll Dice";
            this.BtnDiceRoll.UseVisualStyleBackColor = true;
            this.BtnDiceRoll.Click += new System.EventHandler(this.BtnDiceRoll_Click);
            // 
            // DiceRollProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnDiceRoll);
            this.Name = "DiceRollProblem";
            this.Text = "Dice Roll Problem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDiceRoll;
    }
}

