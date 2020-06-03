namespace GasProblem
{
    partial class FrmGas
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
            this.BtnGas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGas
            // 
            this.BtnGas.Location = new System.Drawing.Point(98, 72);
            this.BtnGas.Name = "BtnGas";
            this.BtnGas.Size = new System.Drawing.Size(75, 35);
            this.BtnGas.TabIndex = 0;
            this.BtnGas.Text = "Problem 4 Gas Problem";
            this.BtnGas.UseVisualStyleBackColor = true;
            this.BtnGas.Click += new System.EventHandler(this.BtnGas_Click);
            // 
            // FrmGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.BtnGas);
            this.Name = "FrmGas";
            this.Text = "Gas Problem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGas;
    }
}

