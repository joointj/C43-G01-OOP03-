using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Diameter { get
            {
                return Radius * 2;
            }
        }
        public double Area { get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Diameter: {Diameter}, Radius: {Radius}, Area: {Area}");
        }
    }
}
