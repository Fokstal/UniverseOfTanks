namespace UniverseOfTanks
{
	public partial class Form1 : Form
	{
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

		public Form1()
		{
			InitializeComponent();
		}

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
		}

		private void PrintModelTank()
		{
			//1 == 15

			int x = _xHeatBoxTank;
			int y = _yHeatBoxTank;

			Pen greenPen = new Pen(Color.DarkGreen, 15);
			Pen blackPen = new Pen(Color.Black, 15);
			Pen greenLPen = new Pen(Color.Green, 15);
			Pen grayPen = new Pen(Color.DarkGray, 15);

			if (_graphics != null)
			{

				//Body
				_graphics.DrawLine(greenPen, x - 45, y - 60, x + 45, y - 60);
				_graphics.DrawLine(greenPen, x - 45, y - 45, x - 60, y - 45);
				_graphics.DrawLine(greenPen, x + 45, y - 45, x + 60, y - 45);
				_graphics.DrawLine(greenPen, x - 90, y - 30, x - 60, y - 30);
				_graphics.DrawLine(greenPen, x + 90, y - 30, x + 60, y - 30);

				_graphics.DrawLine(greenPen, x - 97, y - 22, x - 97, y + 22);
				_graphics.DrawLine(greenPen, x + 97, y - 22, x + 97, y + 22);

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
				_graphics.DrawLine(greenLPen, x - 27, y - 67, x - 27, y - 37);
				_graphics.DrawLine(greenLPen, x + 27, y - 67, x + 27, y - 37);
				_graphics.DrawLine(greenLPen, x - 42, y - 37, x - 42, y + 22);
				_graphics.DrawLine(greenLPen, x + 42, y - 37, x + 42, y + 22);
				_graphics.DrawLine(greenLPen, x - 37, y + 27, x + 37, y + 27);

				//Rifle
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
			}
		}
	}
}