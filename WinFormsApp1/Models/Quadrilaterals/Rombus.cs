﻿
namespace WinFormsApp1.Quadrilaterals
{
    public partial class Rombus : Models.Quadrilaterals.Quadrilaterals
    {
        public double Side { get => _sideA; set => _sideA = _sideB = value; }
        public double DiagonalA { get => _diagonalA; set => _diagonalA = value; }
        public double DiagonalB { get => Math.Sqrt(_sideA * _sideA - (_diagonalA / 2) * (_diagonalA / 2)) * 2; set => _diagonalB = value; }
        public new string BorderColor { get => _borderColor; set => _borderColor = value; }
        public new double Area { get => _area; set => _area = value; }
        public new double Perimeter { get => _perimeter; set => _perimeter = value; }

        public Rombus()
        {
            InitializeComponent();
        }
        protected override void comboBoxChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _borderColor = comboBoxChangeColor.SelectedItem.ToString()!;
        }
        private void Rombus_Load(object sender, EventArgs e)
        {
            foreach (var color in Enum.GetValues(typeof(Constants.Colors)))
            {
                comboBoxChangeColor.Items.Add(color);
                comboBoxChangeColor.SelectedIndex = 0;
            }
        }

        protected override void buttonSubmit_Click(object sender, EventArgs e)
        {
            List<string> entries = new List<string>() { textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text };
            if (!ClassLibrary.Validator.IsNumber(entries))
            {
                MessageBox.Show("Invalid input. Please enter numeric values for all three sides.");
                return;
            }

            double.TryParse(textBox1.Text, out _sideA);
            double.TryParse(textBox2.Text, out _diagonalA);
            int.TryParse(textBox4.Text, out _startPoint[0]);
            int.TryParse(textBox5.Text, out _startPoint[1]);

            List<double> vals = new List<double>() { _sideA, _diagonalA };

            if (!ClassLibrary.Validator.IsZero(vals))
            {
                MessageBox.Show("Invalid input. Please enter non zero numbers.");
                return;
            }

            if (!ClassLibrary.Validator.IsDiagonalLongest(vals))
            {
                MessageBox.Show("The diagonal lenght should be longer than the sum of two sides.");
                return;
            }
            _sideB = _sideA;

            Area = SetArea();
            Perimeter = SetPerimeter();


            DialogResult = DialogResult.OK;
        }

        public double SetArea()
        {
            return Math.Round((_diagonalA * DiagonalB) / 2, 2);
        }

        public double SetPerimeter()
        {
            return Math.Round((_sideA + _sideB) * 2, 2);
        }

        public override void Draw(Panel panel, int ratio, bool isSelected)
        {
            Graphics g = panel.CreateGraphics();

            Point p1 = new Point(X, Y);
            Point p2 = new Point(X + (int)(_diagonalA / 2 * ratio), Y + (int)(DiagonalB / 2 * ratio));
            Point p3 = new Point(X + (int)(_diagonalA * ratio), Y);
            Point p4 = new Point(X + (int)(_diagonalA / 2 * ratio), Y - (int)(DiagonalB / 2 * ratio));
            Point[] points = new Point[] { p1, p2, p3, p4 };

            Pen pen = new Pen(Color.White, 15);
            g.DrawPolygon(pen, points);

            Color colorChoice = Color.FromName(_borderColor);

            int size = isSelected ? 5 : 2;
            pen = new Pen(colorChoice, size);
            g.DrawPolygon(pen, points);

            pen.Dispose();
            g.Dispose();
        }

    }
}
