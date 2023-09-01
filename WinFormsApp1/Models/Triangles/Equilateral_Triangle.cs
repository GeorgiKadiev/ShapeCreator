using WinFormsApp1.Models.Triangles;

namespace WinFormsApp1.Triangles
{
    public partial class EquilateralTriangle : Triangle
    {
        public double SideA { get => _sideA; set => _sideA = _sideB = _sideC = value; }
        public double TriangleHeight { get => Math.Sqrt(_sideA * _sideA - (_sideA / 2) * (_sideA / 2)); set => _height = value; }
        public new string BorderColor { get => _borderColor; set => _borderColor = value; }
        public new double Area { get => _area; set => _area = value; }
        public new double Perimeter { get => _perimeter; set => _perimeter = value; }

        public EquilateralTriangle()
        {
            InitializeComponent();
        }
        protected override void comboBoxChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _borderColor = comboBoxChangeColor.SelectedItem.ToString()!;
        }

        private void Equilateral_Triangle_Load(object sender, EventArgs e)
        {
            foreach (var color in Enum.GetValues(typeof(Constants.Colors)))
            {
                comboBoxChangeColor.Items.Add(color);
                comboBoxChangeColor.SelectedIndex = 0;
            }
        }


        protected override void buttonSubmit_Click(object sender, EventArgs e)
        {
            List<string> entries = new List<string>() { textBox1.Text, textBox3.Text, textBox4.Text };
            if (!ClassLibrary.Validator.IsNumber(entries))
            {
                MessageBox.Show("Invalid input. Please enter numeric values for all three sides.");
                return;
            }

            double.TryParse(textBox1.Text, out _sideA);
            int.TryParse(textBox3.Text, out _startPoint[0]);
            int.TryParse(textBox4.Text, out _startPoint[1]);

            List<double> vals = new List<double>() { _sideA };

            if (!ClassLibrary.Validator.IsZero(vals))
            {
                MessageBox.Show("Invalid input. Please enter non zero numbers.");
                return;
            }
            _sideB = _sideA;
            _sideC = _sideA;
            _height = TriangleHeight;
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
            var point1 = new Point((int)(_sideC / 2 * ratio + X), (int)(Y - TriangleHeight * ratio));
            var point2 = new Point((int)(_sideC * ratio + X), Y);
            var point3 = new Point(X, Y);

            Color colorChoice = Color.FromName(_borderColor);

            Pen pen = new Pen(Color.White, 15);
            g.DrawLine(pen, point1, point2);
            g.DrawLine(pen, point2, point3);
            g.DrawLine(pen, point3, point1);


            int size = isSelected ? 5 : 2;
            pen = new Pen(colorChoice, size);
            g.DrawLine(pen, point1, point2);
            g.DrawLine(pen, point2, point3);
            g.DrawLine(pen, point3, point1);
        }

    }
}
