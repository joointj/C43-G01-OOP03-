using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class MyType : IMyType
    {
        // Automatic property [compiler will generate backing field]
        public int Id { get ; set ; }

        public void MyFun(int X)
        {
            Console.WriteLine($"MyType ==> X : {X}");
        }
    }
}
