﻿using System;
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
		const uint eightBitMask = 255;

		public MathPractice()
		{
			InitializeComponent();
		}

		private void MathPractice_Load(object sender, EventArgs e)
		{
			currentScore.DataBindings.Add(new Binding("Text", score, "ScoreString", false, DataSourceUpdateMode.OnPropertyChanged));

			questionType.Items.Add("Multiples of 16");
			questionType.Items.Add("Dec to Hex (0-15)");
			questionType.Items.Add("Dec to Hex (0-255)");
			questionType.Items.Add("Hex to Dec (0-15)");
			questionType.Items.Add("Hex to Dec (0-255)");
			questionType.Items.Add("Dec to Bin (0-15)");
			questionType.Items.Add("Dec to Bin (0-255)");
			questionType.Items.Add("Bin to Dec (0-15)");
			questionType.Items.Add("Bin to Dec (0-255)");
			questionType.Items.Add("Subnet Masks A.B.C.D to /BitsOfMask");
			questionType.Items.Add("Subnet Masks /BitsOfMask to A.B.C.D");
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
				case "Dec to Bin (0-15)":
					instructions.Text = "Dec to Bin: Convert the following number from decimal to binary. Your answer should have 4 digits (e.g. 2 dec = 0010 bin); use leading zeros if necessary.";
					break;
				case "Dec to Bin (0-255)":
					instructions.Text = "Dec to Bin: Convert the following number from decimal to binary. Your answer should have 8 digits (e.g. 3 dec = 00000011 bin); use leading zeros if necessary.";
					break;
				case "Bin to Dec (0-15)":
				case "Bin to Dec (0-255)":
					instructions.Text = "Bin to Dec: Convert the following number from binary to decimal.";
					break;
				case "Subnet Masks A.B.C.D to /BitsOfMask":
					instructions.Text = "Subnet Masks: Convert the subnet mask to the number of bits of mask. Enter your anser as /number (e.g. 255.255.255.0 would be entered as /24)";
					break;
				case "Subnet Masks /BitsOfMask to A.B.C.D":
					instructions.Text =  "Subnet Masks: Convert the number of bits of mask to a subnet mask (e.g. /24 would be entered as 255.255.255.0)";
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
				case "Dec to Bin (0-15)":
					var f = random.Next(16);
					question.Text = f.ToString();
					expectedAnswer = Convert.ToString(f, 2).PadLeft(4, '0');
					break;
				case "Dec to Bin (0-255)":
					var g = random.Next(256);
					question.Text = g.ToString();
					expectedAnswer = Convert.ToString(g, 2).PadLeft(8, '0');
					break;
				case "Bin to Dec (0-15)":
					var h = random.Next(16);
					expectedAnswer = h.ToString();
					question.Text = Convert.ToString(h, 2).PadLeft(4, '0');
					break;
				case "Bin to Dec (0-255)":
					var i = random.Next(256);
					expectedAnswer = i.ToString();
					question.Text = Convert.ToString(i, 2).PadLeft(8, '0');
					break;
				case "Subnet Masks A.B.C.D to /BitsOfMask":
					var j = random.Next(23) + 8;
					expectedAnswer = "/" + j.ToString();
					question.Text = bitsOfMaskToSubnetMask(j);
					break;
				case "Subnet Masks /BitsOfMask to A.B.C.D":
					var k = random.Next(23) + 8;
					question.Text = "/" + k.ToString();
					expectedAnswer = bitsOfMaskToSubnetMask(k);
					break;

			}
			answer.Text = "";
			answer.Focus();
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			score.Reset();
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
		}

		private string bitsOfMaskToSubnetMask(int bitsOfMask)
		{
			uint mask = 0;
			for (int i = 0; i < bitsOfMask; i++)
			{
				mask <<= 1;
				mask += 1;
			}
			mask <<= (32 - bitsOfMask);
			return ((mask >> 24) & eightBitMask).ToString() + "." + ((mask >> 16) & eightBitMask).ToString() + "." + ((mask >> 8) & eightBitMask).ToString() + "." + (mask & eightBitMask).ToString();


		}
	}

	class Score : INotifyPropertyChanged
	{
		private int incorrect;
		private int correct;

		public int Correct
		{
			get => correct;
			set
			{
				correct = value;
				NotifyPropertyChanged(nameof(ScoreString));
			}
		}
		public int Incorrect
		{
			get => incorrect;
			set
			{
				incorrect = value;
				NotifyPropertyChanged(nameof(ScoreString));
			}
		}
		public Score()
		{
			Correct = 0;
			Incorrect = 0;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void Reset()
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
