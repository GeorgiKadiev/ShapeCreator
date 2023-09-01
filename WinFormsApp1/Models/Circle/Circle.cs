using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Circle : Shape, IShapeCalculations
    {
        private double _radius;
        public double Radius { get => _radius; set => _radius = value; }
        public new string BorderColor { get => _borderColor; set => _borderColor = value; }
        public new double Area { get => _area; set => _area = value; }
        public new double Perimeter { get => _perimeter; set => _perimeter = value; }

        public Circle()
        {
            InitializeComponent();
        }
        private void comboBoxChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _borderColor = comboBoxChangeColor.SelectedItem.ToString()!;
        }
        private void Circle_Load(object sender, EventArgs e)
        {
            foreach (var color in Enum.GetValues(typeof(Constants.Colors)))
            {
                comboBoxChangeColor.Items.Add(color);
                comboBoxChangeColor.SelectedIndex = 0;
            }
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            List<string> entries = new List<string>() { textBox1.Text, textBox2.Text, textBox3.Text };
            if (!ClassLibrary.Validator.IsNumber(entries))
            {
                MessageBox.Show("Invalid input. Please enter numeric values for all three sides.");
                return;
            }

            double.TryParse(textBox1.Text, out _radius);
            int.TryParse(textBox2.Text, out _startPoint[0]);
            int.TryParse(textBox3.Text, out _startPoint[1]);

            List<double> vals = new List<double>() { _radius };

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
            return Math.Round((_radius * _radius) * Math.PI, 2);
        }

        public double SetPerimeter()
        {
            return Math.Round(2 * Math.PI * _radius, 2);
        }

        public override void Draw(Panel panel, int ratio, bool isSelected)
        {
            Graphics g = panel.CreateGraphics();

            Color colorChoice = Color.FromName(_borderColor);

            Pen pen = new Pen(Color.White, 15);
            g.DrawEllipse(pen, X, Y, (int)_radius * ratio * 2, (int)_radius * ratio * 2);

            int size = isSelected ? 5 : 2;
            pen = new Pen(colorChoice, size);


            g.DrawEllipse(pen, X, Y, (int)_radius * ratio * 2, (int)_radius * ratio * 2);
        }

    }
}
