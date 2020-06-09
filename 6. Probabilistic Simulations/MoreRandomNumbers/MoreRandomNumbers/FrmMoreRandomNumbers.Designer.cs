namespace MoreRandomNumbers
{
    partial class FrmMoreRandomNumbers
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
            this.BtnCointToss = new System.Windows.Forms.Button();
            this.BtnDiceSum = new System.Windows.Forms.Button();
            this.BtnDieCounter = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnGamblerGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCointToss
            // 
            this.BtnCointToss.Location = new System.Drawing.Point(13, 42);
            this.BtnCointToss.Name = "BtnCointToss";
            this.BtnCointToss.Size = new System.Drawing.Size(104, 27);
            this.BtnCointToss.TabIndex = 0;
            this.BtnCointToss.Text = "Coin Toss Problem";
            this.BtnCointToss.UseVisualStyleBackColor = true;
            this.BtnCointToss.Click += new System.EventHandler(this.BtnCointToss_Click);
            // 
            // BtnDiceSum
            // 
            this.BtnDiceSum.Location = new System.Drawing.Point(13, 88);
            this.BtnDiceSum.Name = "BtnDiceSum";
            this.BtnDiceSum.Size = new System.Drawing.Size(104, 29);
            this.BtnDiceSum.TabIndex = 1;
            this.BtnDiceSum.Text = "Dice Sum Problem";
            this.BtnDiceSum.UseVisualStyleBackColor = true;
            this.BtnDiceSum.Click += new System.EventHandler(this.BtnDiceSum_Click);
            // 
            // BtnDieCounter
            // 
            this.BtnDieCounter.Location = new System.Drawing.Point(12, 138);
            this.BtnDieCounter.Name = "BtnDieCounter";
            this.BtnDieCounter.Size = new System.Drawing.Size(104, 28);
            this.BtnDieCounter.TabIndex = 2;
            this.BtnDieCounter.Text = "Die Counter Problem";
            this.BtnDieCounter.UseVisualStyleBackColor = true;
            this.BtnDieCounter.Click += new System.EventHandler(this.BtnDieCounter_Click);
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.Location = new System.Drawing.Point(123, 30);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(210, 173);
            this.LstDisplay.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(202, 226);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(69, 25);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnGamblerGame
            // 
            this.btnGamblerGame.Location = new System.Drawing.Point(13, 188);
            this.btnGamblerGame.Name = "btnGamblerGame";
            this.btnGamblerGame.Size = new System.Drawing.Size(104, 28);
            this.btnGamblerGame.TabIndex = 5;
            this.btnGamblerGame.Text = "Gambler Game";
            this.btnGamblerGame.UseVisualStyleBackColor = true;
            this.btnGamblerGame.Click += new System.EventHandler(this.btnGamblerGame_Click);
            // 
            // FrmMoreRandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.btnGamblerGame);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnDieCounter);
            this.Controls.Add(this.BtnDiceSum);
            this.Controls.Add(this.BtnCointToss);
            this.Name = "FrmMoreRandomNumbers";
            this.Text = "More Random Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCointToss;
        private System.Windows.Forms.Button BtnDiceSum;
        private System.Windows.Forms.Button BtnDieCounter;
        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnGamblerGame;
    }
}

