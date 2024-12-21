using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_Overriding
{
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a , int b) : base(a)
        {
            B = b;
        }
        // override using new keyword ==> masking
        // override with new keyword ==> static binding [early binding]
        // compilation time
        // compiler will bind the method based on reference type not object type
        public new void MyFun01()
        {
            Console.WriteLine("I am derived [Child]");
        }

        // override using override keyword ==> Parent method is public virtual
        // override with override keyword ==> dynamic binding [late binding]
        // runtime [clr]
        // clr will bind method call based on object type not reference type 
        override public void MyFun02()
        {
            Console.WriteLine($"TypeB ==> A = {A} , B = {B}");
        }

    }
}
