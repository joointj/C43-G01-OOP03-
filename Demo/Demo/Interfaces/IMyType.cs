using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    // access modifier allowed with interface
    // internal [default] , public 
    internal interface IMyType
    {
        // access modifier allowed in interface members
        // all access modifiers allowed except private
        // public is the default access modifier for interface members

        // what can i write in interface
        // 1- signature for methods
        public int Id { get; set; } // no backing field is generated 
        // inside class, struct is automatic property [compiler will generate backing field]
        // inside interface is signature for property


        // 2- signature for properties
        public void MyFun(int X); // no implementation

        // 3- default implemented methods [C# 8.0]
        void Print()
        {
            Console.WriteLine("Hello from default implemented method");
        }



    }
}
