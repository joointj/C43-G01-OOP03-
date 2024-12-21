using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    class FullTimeEmployee : Employee
    {
        public double Salary { get; set; }

        public FullTimeEmployee(int id , string name , int age , double salary) : base(id , name , age)
        {
            Salary = salary;
        }

        public new void GetEmployeeType ()
        {
            Console.WriteLine("I am FulTimeEmployee");
        }
        override public void GetEmployeeData ()
        {
            Console.WriteLine($"FullTimeEmployee ==> Id {Id} , Name {Name} , Age {Age} , Salary {Salary}");
        }
    }
}
