using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.OpenClosed;

namespace SOLID
{
    class Program
    {

        static void Main(string[] args)
        {
            AreaCalculator _shapeArea = new AreaCalculator();
            Circle c = new Circle() { Radius = 80 };
            Square s = new Square() { Length = 40 };

            double area = _shapeArea.TotalArea(new Shape[2] {c, s});
           Console.WriteLine(area.ToString());
        }
    }
}
