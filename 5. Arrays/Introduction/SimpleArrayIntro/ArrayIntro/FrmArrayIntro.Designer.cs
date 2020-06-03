namespace WindowsApplication1
{
    partial class FrmArrayIntro
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
            this.BtnAssignment = new System.Windows.Forms.Button();
            this.BtnInstance = new System.Windows.Forms.Button();
            this.BtnInput = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LstInfo = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAverage = new System.Windows.Forms.Button();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAssignment
            // 
            this.BtnAssignment.Location = new System.Drawing.Point(49, 59);
            this.BtnAssignment.Name = "BtnAssignment";
            this.BtnAssignment.Size = new System.Drawing.Size(131, 37);
            this.BtnAssignment.TabIndex = 0;
            this.BtnAssignment.Text = "Assignment Statements";
            this.BtnAssignment.UseVisualStyleBackColor = true;
            this.BtnAssignment.Click += new System.EventHandler(this.BtnAssignment_Click);
            // 
            // BtnInstance
            // 
            this.BtnInstance.Location = new System.Drawing.Point(216, 59);
            this.BtnInstance.Name = "BtnInstance";
            this.BtnInstance.Size = new System.Drawing.Size(130, 38);
            this.BtnInstance.TabIndex = 1;
            this.BtnInstance.Text = "Direct Instantiation";
            this.BtnInstance.UseVisualStyleBackColor = true;
            this.BtnInstance.Click += new System.EventHandler(this.BtnInstance_Click);
            // 
            // BtnInput
            // 
            this.BtnInput.Location = new System.Drawing.Point(52, 127);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(128, 37);
            this.BtnInput.TabIndex = 2;
            this.BtnInput.Text = "Input Box";
            this.BtnInput.UseVisualStyleBackColor = true;
            this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // BtnFile
            // 
            this.BtnFile.Location = new System.Drawing.Point(215, 127);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(128, 38);
            this.BtnFile.TabIndex = 3;
            this.BtnFile.Text = "Data File";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assigning values to each location in the array using";
            // 
            // LstInfo
            // 
            this.LstInfo.FormattingEnabled = true;
            this.LstInfo.Location = new System.Drawing.Point(47, 245);
            this.LstInfo.Name = "LstInfo";
            this.LstInfo.Size = new System.Drawing.Size(298, 121);
            this.LstInfo.TabIndex = 5;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(160, 388);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(92, 22);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAverage
            // 
            this.BtnAverage.Location = new System.Drawing.Point(52, 191);
            this.BtnAverage.Name = "BtnAverage";
            this.BtnAverage.Size = new System.Drawing.Size(127, 36);
            this.BtnAverage.TabIndex = 7;
            this.BtnAverage.Text = "Average - Application";
            this.BtnAverage.UseVisualStyleBackColor = true;
            this.BtnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // btnProblem2
            // 
            this.btnProblem2.Location = new System.Drawing.Point(216, 191);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(127, 36);
            this.btnProblem2.TabIndex = 8;
            this.btnProblem2.Text = "Probem 2";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // FrmArrayIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 416);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.BtnAverage);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.BtnInput);
            this.Controls.Add(this.BtnInstance);
            this.Controls.Add(this.BtnAssignment);
            this.Name = "FrmArrayIntro";
            this.Text = "Array Intro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAssignment;
        private System.Windows.Forms.Button BtnInstance;
        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstInfo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAverage;
        private System.Windows.Forms.Button btnProblem2;
    }
}

