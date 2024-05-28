using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//using ImagePuzzle.Properties;

namespace Puzzle
{
	public partial class Form1 : Form
	{
		private List<PictureBox> puzzle;
		private List<Label> cover;
		private Label[] pushCover = new Label[2];
		private int puzzleSize = 0, clickNumber = 0, totalImage = 30, itemSize = 90;
		private bool allowClick = true;
		private int rows = 0, cols = 0;


		public Form1()
		{
			InitializeComponent();
		}

		private void UniqueRandomNumber(List<int> numbers, int startNumber, int endNumber, int countNumbers)
		{
			Random random = new Random();
			for (int i = 0; i < countNumbers; i++)
			{
				int item = random.Next(startNumber, endNumber + 1);
				while (numbers.IndexOf(item) >= 0)
				{
					item = random.Next(startNumber, endNumber + 1);
				}
				numbers.Add(item);
			}
		}

		private void ShuffleNumber(List<int> numbers)
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			UniqueRandomNumber(list, 0, numbers.Count - 1, numbers.Count);
			list2.AddRange(numbers);
			for (int i = 0; i < numbers.Count; i++)
			{
				numbers[i] = list2[list[i]];
			}
			list.Clear();
			list2.Clear();
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			if (!(numRow.SelectedIndex == -1) && !(numCol.SelectedIndex == -1))
			{
				rows = Convert.ToInt32(numRow.SelectedItem);
				cols = Convert.ToInt32(numCol.SelectedItem);

				puzzleSize = rows * cols;
				if (puzzleSize % 2 != 0)
				{
					MessageBox.Show("حاصلضرب تعداد سطرها و ستونها باید عددی زوج باشد", "ورودی نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					puzzleSize = 0;
					return;
				}

				btnGameSetting.Enabled = false;
				btnCancel.Enabled = true;
				numRow.Enabled = false;
				numCol.Enabled = false;
				btnShowHelp.Enabled = true;




				DrawPuzzle();
				SetFormCenter();
				DrawProgressBar();
				FillPuzzle();
				DarwCover();


			}
			else
			{
				MessageBox.Show("حتما باید تعداد خانه های جدول را وارد کنید");
			}

		}
		private void SetFormCenter()
		{
			Rectangle clientRect = this.ClientRectangle;
			int width = clientRect.Width;
			int height = clientRect.Height;

			// Calculate the center of the screen
			int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
			int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
			int centerX = (screenWidth - width) / 2;
			int centerY = (screenHeight - height) / 2;

			// Set the form location to the center of the screen
			this.Location = new Point(centerX, centerY);
		}
		private void DrawProgressBar()
		{
			TsProgress.Maximum = puzzleSize / 2;
			TsProgress.Minimum = 0;
			TsProgress.Step = 1;
		}

		private void DarwCover()
		{
			cover = new List<Label>();
			for (int i = 0; (decimal)i < rows; i++)
			{
				for (int j = 0; (decimal)j < cols; j++)
				{
					Label label = new Label();
					label.Size = new Size(itemSize, itemSize);
					label.Location = new Point(j * itemSize, i * itemSize);
					label.Name = puzzle[i * cols + j].Name;
					label.BorderStyle = BorderStyle.Fixed3D;
					Label label2 = label;
					cover.Add(label2);
					puzzlePanel.Controls.Add(label2);
					label2.BringToFront();
					label2.Click += CoverItem_Click;
				}
			}
		}

		private void CoverItem_Click(object sender, EventArgs e)
		{
			Label label = new Label();
			label = (Label)sender;
			if (allowClick)
			{
				label.Visible = false;
				clickNumber++;
				if (clickNumber == 1)
				{
					pushCover[0] = label;
				}
				else
				{
					pushCover[1] = label;
					allowClick = false;
					ProgressTimer.Start();
				}
				btnShowHelp.Enabled = false;
			}
		}

		private void FillPuzzle()
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			UniqueRandomNumber(list2, 1, totalImage, puzzleSize / 2);
			for (int i = 0; i < puzzleSize / 2; i++)
			{
				list.Add(list2[i]);
				list.Add(list2[i]);
			}
			ShuffleNumber(list);
			for (int i = 0; i < puzzleSize; i++)
			{
				string path = Path.Combine(Directory.GetCurrentDirectory(), $"Images\\p_{list[i]:D2}.jpg").ToString();
				puzzle[i].Image = Image.FromFile(path);
				puzzle[i].Name = list[i].ToString();
			}
		}

		private void DrawPuzzle()
		{
			int totalWidth = cols * itemSize + 15;
			int totalHeight = rows * (itemSize + 13) + 40;

			MinimumSize = new Size(totalWidth, totalHeight);
			Size = new Size(totalWidth, totalHeight);


			puzzle = new List<PictureBox>();
			for (int i = 0; (decimal)i < rows; i++)
			{
				for (int j = 0; (decimal)j < cols; j++)
				{
					PictureBox pictureBox = new PictureBox();
					pictureBox.Size = new Size(itemSize, itemSize);
					pictureBox.BorderStyle = BorderStyle.None;
					pictureBox.Location = new Point(j * itemSize, i * itemSize);
					pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					PictureBox pictureBox2 = pictureBox;
					puzzle.Add(pictureBox2);
					puzzlePanel.Controls.Add(pictureBox2);
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			puzzlePanel.BackColor = BackColor;
			btnCancel.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			numRow.SelectedIndex = -1;
			numCol.SelectedIndex = -1;
			btnCancel.Enabled = false;
			btnShowHelp.Enabled = false;
			//btnShowHelp.Checked = false;
			btnGameSetting.Enabled = true;
			numRow.Enabled = true;
			numCol.Enabled = true;

			for (int i = 0; i < puzzleSize; i++)
			{
				puzzlePanel.Controls.Remove(puzzle[i]);
				puzzlePanel.Controls.Remove(cover[i]);
			}
			cover.Clear();
			puzzle.Clear();
			puzzleSize = 0;
			TsProgress.Value = 0;
			this.MinimumSize = new Size(420, 150);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("آیــا می خواهیـد خـارج شـوید", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			HelpTimer.Stop();
			//btnShowHelp.Checked = false;
			for (int i = 0; i < puzzleSize; i++)
			{
				cover[i].Visible = true;
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			ProgressTimer.Stop();
			if (pushCover[0].Name != pushCover[1].Name)
			{
				pushCover[0].Visible = true;
				pushCover[1].Visible = true;
			}
			else
			{
				TsProgress.PerformStep();
				if (TsProgress.Value == TsProgress.Maximum)
				{
					MessageBox.Show("شما برنده شدید");
				}
			}
			clickNumber = 0;
			allowClick = true;
		}

		private void btnShowHelp_Click(object sender, EventArgs e)
		{
				for (int i = 0; i < puzzleSize; i++)
				{
					cover[i].Visible = false;
				}
				HelpTimer.Start();
				btnShowHelp.Enabled = false;
		}
	}
}

