using WinFormsApp1.Models.Triangles;

namespace WinFormsApp1.Triangles

{
    public partial class RightTriangle : Triangle
    {
        public double SideA { get => _sideA; set => _sideA = value; }
        public double SideB { get => _sideB; set => _sideB = value; }
        public double SideC { get => Math.Sqrt(_sideA * _sideA + _sideB * _sideB); set => _sideC = value; }
        public new string BorderColor { get => _borderColor; set => _borderColor = value; }
        public new double Area { get => _area; set => _area = value; }
        public new double Perimeter { get => _perimeter; set => _perimeter = value; }

        public RightTriangle()
        {
            InitializeComponent();
            ;
        }

        private void Right_Triangle_Load(object sender, EventArgs e)
        {
            foreach (var color in Enum.GetValues(typeof(Constants.Colors)))
            {
                comboBoxChangeColor.Items.Add(color);
                comboBoxChangeColor.SelectedIndex = 0;
            }
        }

        protected override void comboBoxChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _borderColor = comboBoxChangeColor.SelectedItem.ToString()!;
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
            double.TryParse(textBox2.Text, out _sideB);
            int.TryParse(textBox4.Text, out _startPoint[0]);
            int.TryParse(textBox5.Text, out _startPoint[1]);

            List<double> vals = new List<double>() { _sideA, _sideB };

            if (!ClassLibrary.Validator.IsZero(vals))
            {
                MessageBox.Show("Invalid input. Please enter non zero numbers.");
                return;
            }

            _sideC = SideC;
            Area = SetArea();
            Perimeter = SetPerimeter();

            DialogResult = DialogResult.OK;
        }

        public double SetArea()
        {
            return Math.Round((_sideA * _sideB) / 2, 2);
        }

        public double SetPerimeter()
        {
            return Math.Round(_sideA + _sideB + _sideC, 2);
        }

        public override void Draw(Panel panel, int ratio, bool isSelected)
        {
            var g = panel.CreateGraphics();

            var p1 = new Point(X, Y);
            var p2 = new Point((int)(X + _sideA * ratio), Y);
            var p3 = new Point(X, (int)(Y - _sideB * ratio));
            Point[] points = new Point[] { p1, p2, p3, };

            Color colorChoice = Color.FromName(_borderColor);

            Pen pen = new Pen(Color.White, 15);
            g.DrawPolygon(pen, points);

            int size = isSelected ? 5 : 2;
            pen = new Pen(colorChoice, size);
            g.DrawPolygon(pen, points);
        }
    }
}
