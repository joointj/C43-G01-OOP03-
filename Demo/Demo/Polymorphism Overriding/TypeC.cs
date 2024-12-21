using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_Overriding
{
    // TypeB is direct parent of TypeC
    // TypeA is indirect parent of TypeC

    public class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int a , int b , int c) : base (a , b)
        {
            C = c;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am derived [Grand Child]");
        }
        override public void MyFun02()
        {
            Console.WriteLine($"TypeC ==> A = {A} , B = {B} , C = {C}");
        }
    }
}
