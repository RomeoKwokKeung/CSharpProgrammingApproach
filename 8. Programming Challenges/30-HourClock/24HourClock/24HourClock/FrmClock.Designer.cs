﻿namespace _24HourClock
{
    partial class FrmClock
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
            this.BtnClock = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnClock
            // 
            this.BtnClock.Location = new System.Drawing.Point(78, 44);
            this.BtnClock.Name = "BtnClock";
            this.BtnClock.Size = new System.Drawing.Size(111, 35);
            this.BtnClock.TabIndex = 0;
            this.BtnClock.Text = "24 Hour Conversion";
            this.BtnClock.UseVisualStyleBackColor = true;
            this.BtnClock.Click += new System.EventHandler(this.BtnClock_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(32, 100);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(229, 140);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnClock);
            this.Name = "FrmClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "24 Hour Clock Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClock;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

