using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMathPractice
{
	public partial class MathPractice : Form
	{
		string expectedAnswer = "";
		Random random = new Random();
		Score score = new Score();

		public MathPractice()
		{
			InitializeComponent();
		}

		private void MathPractice_Load(object sender, EventArgs e)
		{
			questionType.Items.Add("Multiples of 16");
			questionType.Items.Add("Dec to Hex (0-15)");
			questionType.Items.Add("Dec to Hex (0-255)");
			questionType.Items.Add("Hex to Dec (0-15)");
			questionType.Items.Add("Hex to Dec (0-255)");
		}

		private string getQType()
		{
			if (questionType.SelectedItem != null) return questionType.SelectedItem.ToString();
			return "";
		}

		private void QuestionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetInstructions(getQType());
		}

		private void SetInstructions(string qType)
		{
			switch (qType)
			{
				case "Multiples of 16":
					instructions.Text = "Multiples of 16: Enter the answer to the problem below.";
					break;
				case "Dec to Hex (0-15)":
					instructions.Text = "Dec to Hex: Convert the number below from decimal to hexidecimal";
					break;
				case "Dec to Hex (0-255)":
					instructions.Text = "Dec to Hex: Convert the number below from decimal to hexidecimal. Your answer should have 2 digits; use a leading 0 if necessary (e.g. 14 Dec = 0E Hex)";
					break;
				case "Hex to Dec (0-15)":
				case "Hex to Dec (0-255)":
					instructions.Text = "Hex to Dec: Convert the number below from hexidecimal to decimal.";
					break;
			}
		}

		private void newProblem(string qType)
		{
			switch (qType)
			{
				case "Multiples of 16":
					var a = random.Next(16);
					expectedAnswer = (a * 16).ToString();
					question.Text = "16 × " + a.ToString();
					break;
				case "Dec to Hex (0-15)":
					var b = random.Next(16);
					expectedAnswer = b.ToString("X1");
					question.Text = b.ToString();
					break;
				case "Dec to Hex (0-255)":
					var c = random.Next(256);
					expectedAnswer = c.ToString("X2");
					question.Text = c.ToString();
					break;
				case "Hex to Dec (0-15)":
					var d = random.Next(16);
					question.Text = d.ToString("X1");
					expectedAnswer = d.ToString();
					break;
				case "Hex to Dec (0-255)":
					var e = random.Next(256);
					question.Text = e.ToString("X2");
					expectedAnswer = e.ToString();
					break;
			}
			answer.Text = "";
			answer.Focus();
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			score = new Score();
			currentScore.Text = score.ScoreString;
			newProblem(getQType());
			answer.Text = "";
			answer.Focus();
		}
	
		private void Enter_Click(object sender, EventArgs e)
		{
			if (answer.Text == "") return;
			if (answer.Text.ToUpper() == expectedAnswer)
			{
				score.Correct++;
				newProblem(getQType());
			}
			else {
				score.Incorrect++;
				answer.Text = "";
				answer.Focus();
			}
			currentScore.Text = score.ScoreString;
		}
	}

	class Score
	{
		public int Correct { get; set; }
		public int Incorrect { get; set; }
		public Score()
		{
			Correct = 0;
			Incorrect = 0;
		}

		public decimal CorrectPct
		{
			get
			{
				if (Correct == 0 && Incorrect == 0) return 1.0m;
				return Convert.ToDecimal(Correct) / Convert.ToDecimal(Correct + Incorrect);
			}
		}

		public string ScoreString
		{
			get
			{
				return Correct.ToString() + "/" + (Correct + Incorrect).ToString() + " (" + CorrectPct.ToString("P0") + ")";
			}
		}
	}
}
