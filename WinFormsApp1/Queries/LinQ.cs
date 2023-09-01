using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Queries
{
    public class LinQ
    {
        public static void findColoredShapes(Storage storage, string borderColor)
        {
            Shape[] arrToOrder = RemoveDeletedShapes(storage);


            string result = "";
            var foundShapes = arrToOrder.Where(s => s.BorderColor == borderColor);

            foreach (var shape in foundShapes)
            {
                result += shape.Name + " Area: " + shape.Area + " Perimeter: " + shape.Perimeter + "\n";
            }
            MessageBox.Show(result);
        }

        public static void firstShapeStats(Storage storage)
        {
            Shape[] arrToOrder = RemoveDeletedShapes(storage);


            Shape firstShape = arrToOrder.First();
            string name = firstShape.Name;
            double area = firstShape.Area;
            double perimeter = firstShape.Perimeter;
            string borderColor = firstShape.BorderColor;
            MessageBox.Show("First shapes is a " + name + " Area is: " + area + " Perimeter is: " + perimeter + " and has " + borderColor + " border color");
        }

        public static void ShapeOrderAcsending(Storage storage, string value)
        {
            Shape[] arrToOrder = RemoveDeletedShapes(storage);
            string result = "";
            if (value == "Area")
            {
                var shapesOrderedByArea = arrToOrder.OrderByDescending(s => s.Area);
                foreach (var shape in shapesOrderedByArea)
                {
                    result += shape.Name + ": " + shape.Area + "\n";
                }
            }

            if (value == "Perimeter")
            {
                var shapesOrderedByPerimeter = arrToOrder.OrderByDescending(s => s.Perimeter);
                foreach (var shape in shapesOrderedByPerimeter)
                {
                    result += shape.Name + ": " + shape.Perimeter + "\n";
                }
            }
            MessageBox.Show(result);
        }

        public static void ShapeOrderDecending(Storage storage, string value)
        {
            Shape[] arrToOrder = RemoveDeletedShapes(storage);
            string result = "";

            if (value == "Area")
            {
                var shapesOrderedByArea = arrToOrder.OrderBy(s => s.Area);
                foreach (var shape in shapesOrderedByArea)
                {
                    result += shape.Name + ": " + shape.Area + "\n";
                }
            }

            if(value == "Perimeter")
            {
                var shapesOrderedByPerimeter = arrToOrder.OrderBy(s => s.Perimeter);
                foreach (var shape in shapesOrderedByPerimeter)
                {
                    result += shape.Name + ": " + shape.Perimeter + "\n";
                }
            }

            MessageBox.Show(result);
        }

        public static Shape[] RemoveDeletedShapes(Storage storage)
        {
            Shape[] arrToOrder = storage.Shapes.Where(s => !s.IsDeleted).ToArray();
            return arrToOrder;
        }

    }
}
