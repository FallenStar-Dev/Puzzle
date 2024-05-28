using System.Windows.Forms;

namespace Puzzle
{
	public partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Timer HelpTimer;

		private Timer ProgressTimer;
		private Panel puzzlePanel;
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			puzzlePanel = new System.Windows.Forms.Panel();
			HelpTimer = new System.Windows.Forms.Timer(components);
			ProgressTimer = new System.Windows.Forms.Timer(components);
			toolStrip1 = new System.Windows.Forms.ToolStrip();
			TsProgress = new System.Windows.Forms.ToolStripProgressBar();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			btnGameSetting = new System.Windows.Forms.ToolStripSplitButton();
			toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			numRow = new System.Windows.Forms.ToolStripComboBox();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			numCol = new System.Windows.Forms.ToolStripComboBox();
			toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			btnApply = new System.Windows.Forms.ToolStripMenuItem();
			btnCancel = new System.Windows.Forms.ToolStripButton();
			btnShowHelp = new System.Windows.Forms.ToolStripButton();
			splitContainer1 = new System.Windows.Forms.SplitContainer();
			toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// puzzlePanel
			// 
			puzzlePanel.AutoSize = true;
			puzzlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			puzzlePanel.BackColor = System.Drawing.SystemColors.Control;
			puzzlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			puzzlePanel.Location = new System.Drawing.Point(0, 0);
			puzzlePanel.Name = "puzzlePanel";
			puzzlePanel.Size = new System.Drawing.Size(404, 75);
			puzzlePanel.TabIndex = 1;
			// 
			// HelpTimer
			// 
			HelpTimer.Interval = 2000;
			HelpTimer.Tick += timer1_Tick;
			// 
			// ProgressTimer
			// 
			ProgressTimer.Interval = 50;
			ProgressTimer.Tick += timer2_Tick;
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = System.Drawing.Color.Gray;
			toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { TsProgress, toolStripSeparator1, btnGameSetting, btnCancel, btnShowHelp });
			toolStrip1.Location = new System.Drawing.Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			toolStrip1.Size = new System.Drawing.Size(404, 32);
			toolStrip1.Stretch = true;
			toolStrip1.TabIndex = 4;
			toolStrip1.Text = "toolStrip1";
			// 
			// TsProgress
			// 
			TsProgress.Name = "TsProgress";
			TsProgress.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
			TsProgress.Size = new System.Drawing.Size(120, 29);
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
			// 
			// btnGameSetting
			// 
			btnGameSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, numRow, toolStripSeparator2, toolStripMenuItem2, numCol, toolStripSeparator3, btnApply });
			btnGameSetting.Image = Properties.Resources.start;
			btnGameSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
			btnGameSetting.Name = "btnGameSetting";
			btnGameSetting.Size = new System.Drawing.Size(105, 29);
			btnGameSetting.Text = "تنظیمات پازل";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			toolStripMenuItem1.Enabled = false;
			toolStripMenuItem1.Image = Properties.Resources.RowPic;
			toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
			toolStripMenuItem1.Text = "تعداد سطر ها";
			// 
			// numRow
			// 
			numRow.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7" });
			numRow.BackColor = System.Drawing.SystemColors.ButtonFace;
			numRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			numRow.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			numRow.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
			numRow.Name = "numRow";
			numRow.Size = new System.Drawing.Size(121, 23);
			numRow.Sorted = true;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			toolStripMenuItem2.Enabled = false;
			toolStripMenuItem2.Image = Properties.Resources.columnPic;
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
			toolStripMenuItem2.Text = "تعداد ستون ها";
			// 
			// numCol
			// 
			numCol.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
			numCol.BackColor = System.Drawing.SystemColors.ButtonFace;
			numCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			numCol.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			numCol.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
			numCol.Name = "numCol";
			numCol.Size = new System.Drawing.Size(121, 23);
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
			// 
			// btnApply
			// 
			btnApply.BackColor = System.Drawing.SystemColors.ControlLight;
			btnApply.Name = "btnApply";
			btnApply.Size = new System.Drawing.Size(181, 22);
			btnApply.Text = "شروع بازی";
			btnApply.Click += btnApply_Click;
			// 
			// btnCancel
			// 
			btnCancel.Enabled = false;
			btnCancel.Image = Properties.Resources.cancel;
			btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new System.Drawing.Size(81, 29);
			btnCancel.Text = "ریست پازل";
			btnCancel.Click += btnCancel_Click;
			// 
			// btnShowHelp
			// 
			btnShowHelp.DoubleClickEnabled = true;
			btnShowHelp.Enabled = false;
			btnShowHelp.Image = (System.Drawing.Image)resources.GetObject("btnShowHelp.Image");
			btnShowHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			btnShowHelp.Name = "btnShowHelp";
			btnShowHelp.Size = new System.Drawing.Size(70, 29);
			btnShowHelp.Text = "راهنمایی";
			btnShowHelp.Click += btnShowHelp_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new System.Drawing.Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(puzzlePanel);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(toolStrip1);
			splitContainer1.Size = new System.Drawing.Size(404, 111);
			splitContainer1.SplitterDistance = 75;
			splitContainer1.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			ClientSize = new System.Drawing.Size(404, 111);
			Controls.Add(splitContainer1);
			DoubleBuffered = true;
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			HelpButton = true;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(420, 150);
			Name = "Form1";
			SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "پازل من";
			TopMost = true;
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripProgressBar TsProgress;
		private System.Windows.Forms.ToolStripSplitButton btnGameSetting;
		private System.Windows.Forms.ToolStripComboBox numRow;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox numCol;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnCancel;
		private System.Windows.Forms.ToolStripButton btnShowHelp;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripMenuItem btnApply;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
	}
}

