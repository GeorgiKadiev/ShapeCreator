using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models.Quadrilaterals
{
    public class Quadrilaterals : Shape, IShapeCalculations
    {
        protected double _sideA;
        protected double _sideB;
        protected double _diagonalA;
        protected double _diagonalB;
        public new double Area { get => _area; set => _area = Math.Round(_sideA * _sideB, 2); }
        public new double Perimeter { get => _perimeter; set => _perimeter = Math.Round((_sideA + _sideB) * 2, 2); }

        protected virtual void comboBoxChangeColor_SelectedIndexChanged(object sender, EventArgs e) { }


        protected virtual void buttonSubmit_Click(object sender, EventArgs e) { }

        public override void Draw(Panel panel, int ratio, bool isSelected)
        {
        }
    }
}
