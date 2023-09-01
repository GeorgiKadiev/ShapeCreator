using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models
{
    public abstract class Shape : Form, IShapeCalculations, IShapeDraw
    {

        public static readonly Random rnd = new();

        private readonly long _id;
        private long _dataId;
        protected int[] _startPoint = new int[2];
        protected string _borderColor = "";
        protected bool _isDeleted = false;
        protected double _area;
        protected double _perimeter;

        public Shape()
        {
            _id = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds() * rnd.Next(int.MaxValue);
        }

        public long Id { get { return _id; } }
        public long DataId { get { return _dataId; } set { _dataId = value; } }
        public string BorderColor { get { return _borderColor; } }
        public bool IsDeleted { get { return _isDeleted; } set { _isDeleted = value; } }
        public int X { get => _startPoint[0]; set => _startPoint[0] = value; }
        public int Y { get => _startPoint[1]; set => _startPoint[1] = value; }
        public double Area { get => _area; set { } }
        public double Perimeter { get => _perimeter; set { } }


        public abstract void Draw(Panel panel, int ratio, bool isSelected);

    }
}