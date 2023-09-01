using WinFormsApp1.Models.Triangles;

namespace WinFormsApp1
{
    public partial class IssocelesTriangle : Triangle
    {

        public double BaseLenght { get => _sideC; set => _sideC = value; }
        public double Hip { get => Math.Sqrt(_height * _height + (_sideC / 2) * (_sideC / 2)); set => _sideB = _sideA = value; }
        public double Heightt { get => _height; set => _height = value; }
        public new string BorderColor { get => _borderColor; set => _borderColor = value; }
        public new double Area { get => _area; set => _area = value; }
        public new double Perimeter { get => _perimeter; set => _perimeter = value; }

        public IssocelesTriangle()
        {
            InitializeComponent();
        }

        protected override void comboBoxChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _borderColor = comboBoxChangeColor.SelectedItem.ToString()!;
        }

        private void IssocelesTriangle_Load(object sender, EventArgs e)
        {
            foreach (var color in Enum.GetValues(typeof(Constants.Colors)))
            {
                comboBoxChangeColor.Items.Add(color);
                comboBoxChangeColor.SelectedIndex = 0;
            }
        }

        protected override void buttonSubmit_Click(object sender, EventArgs e)
        {
            List<string> entries = new List<string>() { textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text };

            if (!ClassLibrary.Validator.IsNumber(entries))
            {
                MessageBox.Show("Invalid input. Please enter numeric values for all three sides.");
                return;
            }

            double.TryParse(textBox1.Text, out _sideC);
            double.TryParse(textBox3.Text, out _height);
            int.TryParse(textBox4.Text, out _startPoint[0]);
            int.TryParse(textBox5.Text, out _startPoint[1]);

            List<double> vals = new List<double>() { _sideC, _height };

            if (!ClassLibrary.Validator.IsZero(vals))
            {
                MessageBox.Show("Invalid input. Please enter non zero numbers.");
                return;
            }
            _sideB = _sideA = Hip;
            Area = SetArea();
            Perimeter = SetPerimeter();

            DialogResult = DialogResult.OK;
        }

        public double SetArea()
        {
            return Math.Round((_sideC * _height) / 2, 2);
        }

        public double SetPerimeter()
        {
            return Math.Round(_sideA + _sideB + _sideC, 2);
        }


        public override void Draw(Panel panel, int ratio, bool isSelected)
        {
            Graphics g = panel.CreateGraphics();

            Point[] points = new Point[3];
            points[0] = new Point((int)(_sideC / 2 * ratio + X), (int)(Y - _height * ratio));
            points[1] = new Point((int)(_sideC * ratio + X), Y);
            points[2] = new Point(X, Y);

            Color colorChoice = Color.FromName(_borderColor);

            Pen pen = new Pen(Color.White, 15);
            g.DrawPolygon(pen, points);


            int size = isSelected ? 5 : 2;
            pen = new Pen(colorChoice, size);
            g.DrawPolygon(pen, points);
        }
    }
}
