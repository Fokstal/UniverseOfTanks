<<<<<<< HEAD
=======
using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

>>>>>>> features
namespace UniverseOfTanks
{
	public partial class Form1 : Form
	{
<<<<<<< HEAD
		private Graphics? _graphics;
		private int _xHeatBoxTank;
		private int _yHeatBoxTank;
		private int _xBullet;
		private int _yBullet;

		private int _step = 0;

		private int Step 
		{
			get { return _step; }
			set
			{
				_step = value;

				if (_step == 20)
				{
					_step = 0;
					if (_graphics != null)
					{
						_graphics.Clear(Color.White);
						PrintModelTank();
					}
					timer1.Stop();
				}
			}
		}

		private int XHeatBoxTank
		{
			get { return _xHeatBoxTank; }
			set
			{
				_xHeatBoxTank = value;

				_xBullet = _xHeatBoxTank - 7;
				_yBullet = _yHeatBoxTank - 240;
			}
		}
=======
		private Graphics _graphics;
		private static Form1 _form1;

		private int _xHeatBoxTank;
		private int _yHeatBoxTank;

		private int _xHeatBoxEnemyTank;
		private int _yHeatBoxEnemyTank;

		private int _xBullet;
		private int _yBullet;

		private static int _score = 0;
>>>>>>> features

		public Form1()
		{
			InitializeComponent();
		}

<<<<<<< HEAD
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			timer1.Interval = (1);
			timer2.Interval = (500);

			_graphics = this.CreateGraphics();

			_xHeatBoxTank = 400;
			_yHeatBoxTank = 400;

			_xBullet = _xHeatBoxTank - 7;
			_yBullet = _yHeatBoxTank - 240;

			//_graphics.DrawLine(new Pen(Color.Yellow, 15), _xHeatBoxTank, _yHeatBoxTank, _xHeatBoxTank, _yHeatBoxTank + 15);

			PrintModelTank();
=======
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
>>>>>>> features
		}

		private void PrintModelTank()
		{
<<<<<<< HEAD
			//1 == 15

			int x = _xHeatBoxTank;
			int y = _yHeatBoxTank;

			Pen greenPen = new Pen(Color.DarkGreen, 15);
			Pen blackPen = new Pen(Color.Black, 15);
			Pen greenLPen = new Pen(Color.Green, 15);
			Pen grayPen = new Pen(Color.DarkGray, 15);
=======
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
>>>>>>> features

			if (_graphics != null)
			{

				//Body
<<<<<<< HEAD
				_graphics.DrawLine(greenPen, x - 45, y - 60, x + 45, y - 60);
				_graphics.DrawLine(greenPen, x - 45, y - 45, x - 60, y - 45);
				_graphics.DrawLine(greenPen, x + 45, y - 45, x + 60, y - 45);
				_graphics.DrawLine(greenPen, x - 90, y - 30, x - 60, y - 30);
				_graphics.DrawLine(greenPen, x + 90, y - 30, x + 60, y - 30);
=======
				_graphics.DrawLine(greenPen, x - 30, y - 40, x + 30, y - 40);
				_graphics.DrawLine(greenPen, x - 30, y - 30, x - 40, y - 30);
				_graphics.DrawLine(greenPen, x + 30, y - 30, x + 40, y - 30);
				_graphics.DrawLine(greenPen, x - 90, y - 20, x - 40, y - 20);
				_graphics.DrawLine(greenPen, x + 90, y - 20, x + 40, y - 20);
>>>>>>> features

				_graphics.DrawLine(greenPen, x - 97, y - 22, x - 97, y + 22);
				_graphics.DrawLine(greenPen, x + 97, y - 22, x + 97, y + 22);

<<<<<<< HEAD
				_graphics.DrawLine(greenPen, x - 45, y + 60, x + 45, y + 60);
				_graphics.DrawLine(greenPen, x - 45, y + 45, x - 60, y + 45);
				_graphics.DrawLine(greenPen, x + 45, y + 45, x + 60, y + 45);
				_graphics.DrawLine(greenPen, x - 90, y + 30, x - 60, y + 30);
				_graphics.DrawLine(greenPen, x + 90, y + 30, x + 60, y + 30);


				//Caterpillar`s
				_graphics.DrawLine(blackPen, x - 120, y - 105, x + 120, y - 105);
				_graphics.DrawLine(blackPen, x - 135, y - 90, x - 120, y - 90);
				_graphics.DrawLine(blackPen, x + 135, y - 90, x + 120, y - 90);
				_graphics.DrawLine(blackPen, x - 120, y - 75, x + 120, y - 75);

				_graphics.DrawLine(blackPen, x - 120, y + 105, x + 120, y + 105);
				_graphics.DrawLine(blackPen, x - 135, y + 90, x - 120, y + 90);
				_graphics.DrawLine(blackPen, x + 135, y + 90, x + 120, y + 90);
				_graphics.DrawLine(blackPen, x - 120, y + 75, x + 120, y + 75);

				//Head
				_graphics.DrawLine(greenLPen, x - 20, y - 75, x + 20, y - 75);
=======
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
>>>>>>> features
				_graphics.DrawLine(greenLPen, x - 27, y - 67, x - 27, y - 37);
				_graphics.DrawLine(greenLPen, x + 27, y - 67, x + 27, y - 37);
				_graphics.DrawLine(greenLPen, x - 42, y - 37, x - 42, y + 22);
				_graphics.DrawLine(greenLPen, x + 42, y - 37, x + 42, y + 22);
				_graphics.DrawLine(greenLPen, x - 37, y + 27, x + 37, y + 27);

				//Rifle
<<<<<<< HEAD
				_graphics.DrawLine(greenLPen, x, y - 75, x, y - 75 - 120);
				_graphics.DrawLine(grayPen, x - 15, y - 195, x + 15, y - 195);
				_graphics.DrawLine(grayPen, x - 20, y - 210, x + 20, y - 210);
			}
		}

		private void PrintBullet()
		{
			Pen redPen = new Pen(Color.OrangeRed, 15);

			if (_graphics != null)
			{
				_graphics.DrawEllipse(redPen, _xBullet, _yBullet, 15, 15);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (_graphics != null)
			{
				_graphics.Clear(Color.White);

				PrintModelTank();

				_yBullet -= 10;
				PrintBullet();
			}

			Step++;
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (_graphics != null) _graphics.Clear(Color.White);
=======
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
>>>>>>> features

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
<<<<<<< HEAD
				_yBullet = _yHeatBoxTank - 240;

				timer1.Interval = 50;
				timer1.Start();
			}

			PrintModelTank();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (_graphics != null)
			{
				_graphics.Clear(Color.White);
=======
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
>>>>>>> features
			}
		}
	}
}