
namespace WinFormsApp1.Quadrilaterals
{
    public partial class Rectanglee : Models.Quadrilaterals.Quadrilaterals
    {
        public double SideA { get => _sideA; set => _sideA = value; }
        public double SideB { get => _sideB; set => _sideB = value; }
        public new string BorderColor { get => _borderColor; set => _borderColor = value; }
        public new double Area { get => _area; set => _area = value; }
        public new double Perimeter { get => _perimeter; set => _perimeter = value; }


        public Rectanglee()
        {
            InitializeComponent();
        }
        private void Rectanglee_Load(object sender, EventArgs e)
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
            List<string> entries = new List<string>() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            if (!ClassLibrary.Validator.IsNumber(entries))
            {
                MessageBox.Show("Invalid input. Please enter numeric values for all three sides.");
                return;
            }

            double.TryParse(textBox1.Text, out _sideA);
            double.TryParse(textBox2.Text, out _sideB);
            int.TryParse(textBox3.Text, out _startPoint[0]);
            int.TryParse(textBox4.Text, out _startPoint[1]);

            List<double> vals = new List<double>() { _sideA, _sideB };

            if (!ClassLibrary.Validator.IsZero(vals))
            {
                MessageBox.Show("Invalid input. Please enter non zero numbers.");
                return;
            }
            Area = SetArea();
            Perimeter = SetPerimeter();

            DialogResult = DialogResult.OK;
        }

        public double SetArea()
        {
            return Math.Round(_sideA * _sideB, 2);
        }

        public double SetPerimeter()
        {
            return Math.Round((_sideA + _sideB) * 2, 2);
        }

        public override void Draw(Panel panel, int ratio, bool isSelected)
        {

            Graphics g = panel.CreateGraphics();

            Point topLeft = new Point(X, Y);
            Point topRight = new Point((int)_sideA * ratio + X, Y);
            Point bottomLeft = new Point(X, (int)_sideB * ratio + Y);
            Point bottomRight = new Point((int)_sideA * ratio + X, (int)_sideB * ratio + Y);

            Color colorChoice = Color.FromName(_borderColor);

            Pen pen = new Pen(Color.White, 15);
            g.DrawLine(pen, topLeft, topRight);
            g.DrawLine(pen, topLeft, bottomLeft);
            g.DrawLine(pen, topRight, bottomRight);
            g.DrawLine(pen, bottomLeft, bottomRight);

            int size = isSelected ? 5 : 2;
            pen = new Pen(colorChoice, size);

            g.DrawLine(pen, topLeft, topRight);
            g.DrawLine(pen, topLeft, bottomLeft);
            g.DrawLine(pen, topRight, bottomRight);
            g.DrawLine(pen, bottomLeft, bottomRight);
        }

    }
}
