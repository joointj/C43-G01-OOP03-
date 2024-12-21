using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_Overriding
{
    public class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int a , int b , int c, int d) : base (a , b , c)
        {
            D = d;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am derived [Child of Grand Child]");
        }
        // using new when this method is public virtual on the base class 
        // this will end the sequence of overriding
        // using new virtual will start a new sequence of overriding
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeD ==> A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }
}
