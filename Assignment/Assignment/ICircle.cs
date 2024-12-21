using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface ICircle : IShape
    {
        public double Radius { get; set; }
        public double Diameter { get; }
    }
}
