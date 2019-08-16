namespace NetworkMathPractice
{
    partial class MathPractice
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
			this.question = new System.Windows.Forms.Label();
			this.answer = new System.Windows.Forms.TextBox();
			this.enter = new System.Windows.Forms.Button();
			this.questionType = new System.Windows.Forms.ComboBox();
			this.questionTypeLabel = new System.Windows.Forms.Label();
			this.reset = new System.Windows.Forms.Button();
			this.instructions = new System.Windows.Forms.Label();
			this.currentScore = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// question
			// 
			this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.question.Location = new System.Drawing.Point(8, 72);
			this.question.Name = "question";
			this.question.Size = new System.Drawing.Size(440, 152);
			this.question.TabIndex = 0;
			this.question.Text = "Select a question type below";
			// 
			// answer
			// 
			this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.answer.Location = new System.Drawing.Point(8, 232);
			this.answer.Name = "answer";
			this.answer.Size = new System.Drawing.Size(440, 29);
			this.answer.TabIndex = 1;
			this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// enter
			// 
			this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enter.Location = new System.Drawing.Point(368, 272);
			this.enter.Name = "enter";
			this.enter.Size = new System.Drawing.Size(75, 25);
			this.enter.TabIndex = 2;
			this.enter.Text = "Enter";
			this.enter.UseVisualStyleBackColor = true;
			this.enter.Click += new System.EventHandler(this.Enter_Click);
			// 
			// questionType
			// 
			this.questionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.questionType.FormattingEnabled = true;
			this.questionType.Location = new System.Drawing.Point(8, 384);
			this.questionType.Name = "questionType";
			this.questionType.Size = new System.Drawing.Size(192, 24);
			this.questionType.TabIndex = 3;
			this.questionType.SelectedIndexChanged += new System.EventHandler(this.QuestionType_SelectedIndexChanged);
			// 
			// questionTypeLabel
			// 
			this.questionTypeLabel.AutoSize = true;
			this.questionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.questionTypeLabel.Location = new System.Drawing.Point(8, 360);
			this.questionTypeLabel.Name = "questionTypeLabel";
			this.questionTypeLabel.Size = new System.Drawing.Size(101, 17);
			this.questionTypeLabel.TabIndex = 4;
			this.questionTypeLabel.Text = "Question Type";
			// 
			// reset
			// 
			this.reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reset.Location = new System.Drawing.Point(208, 384);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(104, 25);
			this.reset.TabIndex = 2;
			this.reset.Text = "Start / Reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// instructions
			// 
			this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.instructions.Location = new System.Drawing.Point(8, 8);
			this.instructions.Name = "instructions";
			this.instructions.Size = new System.Drawing.Size(440, 56);
			this.instructions.TabIndex = 5;
			this.instructions.Text = "Instructions: Select a question type below.";
			// 
			// currentScore
			// 
			this.currentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentScore.Location = new System.Drawing.Point(8, 272);
			this.currentScore.Name = "currentScore";
			this.currentScore.Size = new System.Drawing.Size(176, 24);
			this.currentScore.TabIndex = 5;
			this.currentScore.Text = "0/0 (100%)";
			// 
			// MathPractice
			// 
			this.AcceptButton = this.enter;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.reset;
			this.ClientSize = new System.Drawing.Size(463, 433);
			this.Controls.Add(this.currentScore);
			this.Controls.Add(this.instructions);
			this.Controls.Add(this.questionTypeLabel);
			this.Controls.Add(this.questionType);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.enter);
			this.Controls.Add(this.answer);
			this.Controls.Add(this.question);
			this.Name = "MathPractice";
			this.Text = "Network Math Practice";
			this.Load += new System.EventHandler(this.MathPractice_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.ComboBox questionType;
        private System.Windows.Forms.Label questionTypeLabel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label instructions;
		private System.Windows.Forms.Label currentScore;
	}
}

