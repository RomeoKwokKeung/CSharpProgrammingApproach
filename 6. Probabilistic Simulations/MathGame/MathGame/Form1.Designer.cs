namespace MathGame
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Question = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Feedback = new System.Windows.Forms.Label();
            this.CheckAnswer = new System.Windows.Forms.Button();
            this.NextQuestion = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Game";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select the type of math problems you would like to solve? ";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(163, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Multiplication";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Subtraction";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Addition";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(19, 120);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(73, 20);
            this.Question.TabIndex = 2;
            this.Question.Text = "Question";
            this.Question.Visible = false;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(23, 153);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 20);
            this.Answer.TabIndex = 3;
            this.Answer.Visible = false;
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Feedback.Location = new System.Drawing.Point(132, 153);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(80, 20);
            this.Feedback.TabIndex = 4;
            this.Feedback.Text = "Feedback";
            this.Feedback.Visible = false;
            // 
            // CheckAnswer
            // 
            this.CheckAnswer.Location = new System.Drawing.Point(23, 190);
            this.CheckAnswer.Name = "CheckAnswer";
            this.CheckAnswer.Size = new System.Drawing.Size(100, 23);
            this.CheckAnswer.TabIndex = 5;
            this.CheckAnswer.Text = "Check Answer";
            this.CheckAnswer.UseVisualStyleBackColor = true;
            this.CheckAnswer.Visible = false;
            this.CheckAnswer.Click += new System.EventHandler(this.CheckAnswer_Click);
            // 
            // NextQuestion
            // 
            this.NextQuestion.Location = new System.Drawing.Point(136, 190);
            this.NextQuestion.Name = "NextQuestion";
            this.NextQuestion.Size = new System.Drawing.Size(110, 23);
            this.NextQuestion.TabIndex = 6;
            this.NextQuestion.Text = "Next Question";
            this.NextQuestion.UseVisualStyleBackColor = true;
            this.NextQuestion.Visible = false;
            this.NextQuestion.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(23, 229);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 7;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 266);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.NextQuestion);
            this.Controls.Add(this.CheckAnswer);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Math Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label Feedback;
        private System.Windows.Forms.Button CheckAnswer;
        private System.Windows.Forms.Button NextQuestion;
        private System.Windows.Forms.Button StartGame;
    }
}

