namespace UniverseOfTanks
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
<<<<<<< HEAD
			components = new System.ComponentModel.Container();
			timer1 = new System.Windows.Forms.Timer(components);
			timer2 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// timer2
			// 
			timer2.Tick += timer2_Tick;
=======
			scoreBox = new Label();
			menuStrip1 = new MenuStrip();
			gameToolStripMenuItem = new ToolStripMenuItem();
			pauseToolStripMenuItem = new ToolStripMenuItem();
			scoreLabel = new Label();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// scoreBox
			// 
			scoreBox.AutoSize = true;
			scoreBox.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			scoreBox.Location = new Point(67, 28);
			scoreBox.Name = "scoreBox";
			scoreBox.Size = new Size(34, 38);
			scoreBox.TabIndex = 0;
			scoreBox.Text = "0";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(782, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// gameToolStripMenuItem
			// 
			gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pauseToolStripMenuItem });
			gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			gameToolStripMenuItem.Size = new Size(62, 24);
			gameToolStripMenuItem.Text = "Game";
			gameToolStripMenuItem.Click += gameToolStripMenuItem_Click;
			// 
			// pauseToolStripMenuItem
			// 
			pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
			pauseToolStripMenuItem.Size = new Size(129, 26);
			pauseToolStripMenuItem.Text = "Pause";
			pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click_1;
			// 
			// scoreLabel
			// 
			scoreLabel.AutoSize = true;
			scoreLabel.Location = new Point(12, 42);
			scoreLabel.Name = "scoreLabel";
			scoreLabel.Size = new Size(49, 20);
			scoreLabel.TabIndex = 2;
			scoreLabel.Text = "Score:";
>>>>>>> features
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(782, 753);
<<<<<<< HEAD
			Name = "Form1";
			Text = "Form1";
			Paint += Form1_Paint;
			KeyPress += Form1_KeyPress;
			ResumeLayout(false);
=======
			Controls.Add(scoreLabel);
			Controls.Add(scoreBox);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Universe of Tanks";
			WindowState = FormWindowState.Maximized;
			Paint += Painter;
			KeyPress += Form1_KeyPress;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
>>>>>>> features
		}

		#endregion

<<<<<<< HEAD
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
=======
		private Label scoreBox;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem gameToolStripMenuItem;
		private ToolStripMenuItem pauseToolStripMenuItem;
		private Label scoreLabel;
>>>>>>> features
	}
}