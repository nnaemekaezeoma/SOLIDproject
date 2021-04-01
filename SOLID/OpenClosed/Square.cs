using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed
{
    public class Square: Shape
    {
        public double Length { get; set; }

        public override double Area()
        {
            return Length * Length;
        }
    }
}
