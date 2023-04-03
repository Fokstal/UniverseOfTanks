using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace UniverseOfTanks
{
	public partial class Form1 : Form
	{
		private Graphics _graphics;
		private static Form1 _form1;

		private int _xHeatBoxTank;
		private int _yHeatBoxTank;

		private int _xHeatBoxEnemyTank;
		private int _yHeatBoxEnemyTank;

		private int _xBullet;
		private int _yBullet;

		private static int _score = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Painter(object sender, PaintEventArgs e)
		{
			_graphics = CreateGraphics();
			_form1 = this;

			StartGame();
		}

		private void StartGame()
		{
			Random random = new Random();

			_xHeatBoxEnemyTank = random.Next(100, 1900);
			Thread.Sleep(1);
			_yHeatBoxEnemyTank = random.Next(100, 200);

			_xHeatBoxTank = 1000;
			_yHeatBoxTank = 800;

			PrintModelTank();

			PrintEnemyModelTank();
		}

		private void PrintModelTank()
		{
			//Set score to scoreBox
			scoreBox.Text = _score + "";
			//

			int x = _xHeatBoxTank;
			int y = _yHeatBoxTank;
			int penWidth = 15;

			Pen greenPen = new Pen(Color.DarkGreen, penWidth);
			Pen blackPen = new Pen(Color.Black, penWidth);
			Pen greenLPen = new Pen(Color.Green, penWidth);
			Pen grayPen = new Pen(Color.DarkGray, penWidth);

			if (_graphics != null)
			{

				//Body
				_graphics.DrawLine(greenPen, x - 30, y - 40, x + 30, y - 40);
				_graphics.DrawLine(greenPen, x - 30, y - 30, x - 40, y - 30);
				_graphics.DrawLine(greenPen, x + 30, y - 30, x + 40, y - 30);
				_graphics.DrawLine(greenPen, x - 90, y - 20, x - 40, y - 20);
				_graphics.DrawLine(greenPen, x + 90, y - 20, x + 40, y - 20);

				_graphics.DrawLine(greenPen, x - 97, y - 22, x - 97, y + 22);
				_graphics.DrawLine(greenPen, x + 97, y - 22, x + 97, y + 22);

				_graphics.DrawLine(greenPen, x - 30, y + 40, x + 30, y + 40);
				_graphics.DrawLine(greenPen, x - 30, y + 30, x - 40, y + 30);
				_graphics.DrawLine(greenPen, x + 30, y + 30, x + 40, y + 30);
				_graphics.DrawLine(greenPen, x - 90, y + 20, x - 40, y + 20);
				_graphics.DrawLine(greenPen, x + 90, y + 20, x + 40, y + 20);


				//Caterpillar`s
				_graphics.DrawLine(blackPen, x - 80, y - 70, x + 80, y - 70);
				_graphics.DrawLine(blackPen, x - 90, y - 60, x - 80, y - 60);
				_graphics.DrawLine(blackPen, x + 90, y - 60, x + 80, y - 60);
				_graphics.DrawLine(blackPen, x - 80, y - 50, x + 80, y - 50);

				_graphics.DrawLine(blackPen, x - 80, y + 70, x + 80, y + 70);
				_graphics.DrawLine(blackPen, x - 90, y + 60, x - 80, y + 60);
				_graphics.DrawLine(blackPen, x + 90, y + 60, x + 80, y + 60);
				_graphics.DrawLine(blackPen, x - 80, y + 50, x + 80, y + 50);

				//Head
				_graphics.DrawLine(greenLPen, x - 20, y - 50, x + 20, y - 50);
				_graphics.DrawLine(greenLPen, x - 27, y - 67, x - 27, y - 37);
				_graphics.DrawLine(greenLPen, x + 27, y - 67, x + 27, y - 37);
				_graphics.DrawLine(greenLPen, x - 42, y - 37, x - 42, y + 22);
				_graphics.DrawLine(greenLPen, x + 42, y - 37, x + 42, y + 22);
				_graphics.DrawLine(greenLPen, x - 37, y + 27, x + 37, y + 27);

				//Rifle
				_graphics.DrawLine(greenLPen, x, y - 50, x, y - 50 - 80);
				_graphics.DrawLine(grayPen, x - 15, y - 130, x + 15, y - 130);
				_graphics.DrawLine(grayPen, x - 20, y - 140, x + 20, y - 140);
			}
		}

		private void PrintEnemyModelTank()
		{
			int x = _xHeatBoxEnemyTank;
			int y = _yHeatBoxEnemyTank;
			int penWidth = 15;

			Pen greenPen = new Pen(Color.DarkRed, penWidth);
			Pen blackPen = new Pen(Color.Black, penWidth);
			Pen greenLPen = new Pen(Color.Red, penWidth);
			Pen grayPen = new Pen(Color.DarkGray, penWidth);

			if (_graphics != null)
			{

				//Body
				_graphics.DrawLine(greenPen, x - 30, y - 40, x + 30, y - 40);
				_graphics.DrawLine(greenPen, x - 30, y - 30, x - 40, y - 30);
				_graphics.DrawLine(greenPen, x + 30, y - 30, x + 40, y - 30);
				_graphics.DrawLine(greenPen, x - 90, y - 20, x - 40, y - 20);
				_graphics.DrawLine(greenPen, x + 90, y - 20, x + 40, y - 20);

				_graphics.DrawLine(greenPen, x - 97, y - 22, x - 97, y + 22);
				_graphics.DrawLine(greenPen, x + 97, y - 22, x + 97, y + 22);

				_graphics.DrawLine(greenPen, x - 30, y + 40, x + 30, y + 40);
				_graphics.DrawLine(greenPen, x - 30, y + 30, x - 40, y + 30);
				_graphics.DrawLine(greenPen, x + 30, y + 30, x + 40, y + 30);
				_graphics.DrawLine(greenPen, x - 90, y + 20, x - 40, y + 20);
				_graphics.DrawLine(greenPen, x + 90, y + 20, x + 40, y + 20);


				//Caterpillar`s
				_graphics.DrawLine(blackPen, x - 80, y - 70, x + 80, y - 70);
				_graphics.DrawLine(blackPen, x - 90, y - 60, x - 80, y - 60);
				_graphics.DrawLine(blackPen, x + 90, y - 60, x + 80, y - 60);
				_graphics.DrawLine(blackPen, x - 80, y - 50, x + 80, y - 50);

				_graphics.DrawLine(blackPen, x - 80, y + 70, x + 80, y + 70);
				_graphics.DrawLine(blackPen, x - 90, y + 60, x - 80, y + 60);
				_graphics.DrawLine(blackPen, x + 90, y + 60, x + 80, y + 60);
				_graphics.DrawLine(blackPen, x - 80, y + 50, x + 80, y + 50); //Опросник взаимодействия "Родителя-ребенок" Марковская #5

				//Head
				_graphics.DrawLine(greenLPen, x - 20, y - 50, x + 20, y - 50);
				_graphics.DrawLine(greenLPen, x - 27, y - 50, x - 27, y - 37);
				_graphics.DrawLine(greenLPen, x + 27, y - 50, x + 27, y - 37);
				_graphics.DrawLine(greenLPen, x - 42, y - 37, x - 42, y + 22);
				_graphics.DrawLine(greenLPen, x + 42, y - 37, x + 42, y + 22);
				_graphics.DrawLine(greenLPen, x - 37, y + 27, x + 37, y + 27);
			}
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			_graphics.Clear(Color.White);

			if (e.KeyChar == 'w')
			{
				_yHeatBoxTank -= 10;
			}

			if (e.KeyChar == 's')
			{
				_yHeatBoxTank += 10;
			}

			if (e.KeyChar == 'd')
			{
				_xHeatBoxTank += 10;
			}

			if (e.KeyChar == 'a')
			{
				_xHeatBoxTank -= 10;
			}

			if (e.KeyChar == ' ')
			{
				_xBullet = _xHeatBoxTank - 7;
				_yBullet = _yHeatBoxTank - 180;

				new Bullet(this, _xBullet, _yBullet, _xHeatBoxEnemyTank, _yHeatBoxEnemyTank);
			}

			if (_temp + 10 == Convert.ToInt32(scoreBox.Text))
			{
				_temp += 10;

				Random random = new Random();

				_xHeatBoxEnemyTank = random.Next(100, 1900);
				Thread.Sleep(1);
				_yHeatBoxEnemyTank = random.Next(100, 200);
			}

			PrintModelTank();
			PrintEnemyModelTank();
		}

		private int _temp = 0;

		public static void addScore(int point)
		{
			_score += point;
		}

		public static void RegistrHit()
		{
			addScore(10);

			_form1.CreateGraphics().Clear(Color.White);
			_form1.PrintModelTank();
		}

		private void pauseToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			new PauseDialogWindow().ShowDialog();
		}

		private void gameToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}

	class Bullet
	{
		private Graphics? _graphics = new Form().CreateGraphics();

		private int _xBullet;
		private int _yBullet;

		private int _xHeatBoxEnemyTank;
		private int _yHeatBoxEnemyTank;

		private List<int> _lineHitsTank = new List<int>();

		private Pen _redPen = new Pen(Color.OrangeRed, 15);

		private static Form1 _form1 = new Form1();

		public Bullet(Form form, int xBullet, int yBullet, int xHeatBoxEnemyTank, int yHeatBoxEnemyTank)
		{
			_graphics = form.CreateGraphics();

			_xBullet = xBullet;
			_yBullet = yBullet;

			_xHeatBoxEnemyTank = xHeatBoxEnemyTank;
			_yHeatBoxEnemyTank = yHeatBoxEnemyTank;

			for (int i = xHeatBoxEnemyTank - 100; i <= xHeatBoxEnemyTank + 100; i++)
			{
				_lineHitsTank.Add(i);
			}

			Fire();
		}

		async Task Fire()
		{
			await Task.Run(() => PrintBullet());
		}

		void PrintBullet()
		{
			for (int i = 0; i < 100; i++)
			{
				Thread.Sleep(100);

				if (_graphics != null)
				{
					_graphics.DrawEllipse(new Pen(Color.White, 15), _xBullet, _yBullet, 15, 15);
					_yBullet -= 10;
					_graphics.DrawEllipse(_redPen, _xBullet, _yBullet, 15, 15);
				}

				if (_yBullet <= _yHeatBoxEnemyTank + 83 && _lineHitsTank.Contains(_xBullet - 15))
				{
					Form1.RegistrHit();
					return;
				}
			}
		}
	}
}