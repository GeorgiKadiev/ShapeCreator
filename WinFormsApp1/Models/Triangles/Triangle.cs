using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models.Triangles
{
    public partial class Triangle : Shape, IShapeCalculations
    {
        protected double _sideA;
        protected double _sideB;
        protected double _sideC;
        protected double _height;


        public new double Area
        {
            get => _area; set => _area = Math.Round(_sideC * _height / 2, 2);
        }
        public new double Perimeter { get => _perimeter; set => _perimeter = Math.Round(_sideA + _sideB + _sideC, 2); }


        protected virtual void comboBoxChangeColor_SelectedIndexChanged(object sender, EventArgs e) { }


        protected virtual void buttonSubmit_Click(object sender, EventArgs e) { }

        public override void Draw(Panel panel, int ratio, bool isSelected)
        {
        }


    }
}
