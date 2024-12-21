using Demo.Binding;
using Demo.Polymorphism_Overriding;
using Demo.Interfaces;

namespace Demo
{
    internal class Program
    {
        static int Sum (int x , int y)
        {
            return x + y;
        }
        static double Sum(double x , int y)
        {
            return x + y;
        }
        static double Sum(int y , double x)
        {
            return x + y;
        }
        static int Sum(int x , int y , int z)
        {
            return x + y + z;
        }

        static void ProcessEmployee (Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType(); // Parent
                employee.GetEmployeeData(); // FullTimeEmployee or PartTimeEmployee
            }
        }
        static void ProcessSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(series.Current + " ");
                    series.GetNext();
                    
                }
                Console.WriteLine();
                series.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Polymorphism - Overloading
            //int Result = Sum(1, 2);
            //Console.WriteLine(Result);

            //Result = Sum(1 , 2 , 3);
            //Console.WriteLine(Result);

            //double Result2 = Sum(2.5 , 3);
            //Console.WriteLine(Result2);

            //Console.WriteLine(true);
            //Console.WriteLine(1);
            //Console.WriteLine("Eslam");
            //Console.WriteLine();
            //Console.WriteLine(1.5);
            //Console.WriteLine(1.5f);
            //Console.WriteLine(1.5m);
            #endregion

            #region Polymorphism - Overriding
            //TypeA typeA = new TypeA(10);
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeB(10 , 20);
            //typeB.MyFun01();
            //typeB.MyFun02();

            #endregion

            #region Binding
            //TypeA refBase;
            //// create reference from TypeA
            //// In stack 4 bytes
            //// refer to null

            //refBase = new TypeB(1, 2);
            //refBase.A = 10; // valid
            //refBase.MyFun01(); // valid [new]
            //refBase.MyFun02(); // valid [override]
            //                   //refBase.B = 20; // invalid


            #endregion

            #region Not Binding
            //TypeB typeB = (TypeB) new TypeA(1); // explicit casting unsafe

            //TypeA typeA = new TypeB(1, 2); // reference from parent to object of child

            //TypeB typeB = (TypeB)typeA; // valid [assign object from TypeB to reference from TypeB]

            #endregion

            #region Binding Example 1
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, "Eslam" , 20 , 2000);
            //ProcessEmployee(fullTimeEmployee);

            //// object initializer .net 6 
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 2,
            //    Name = "Ahmed",
            //    Age = 25,
            //    HourRate = 20,
            //    CountOfHours = 100,
            //};

            //ProcessEmployee(partTimeEmployee);
            #endregion

            #region Binding Example 2
            //TypeB typeB = new TypeC(1, 2, 3); // typeB is direct parent of TypeC
            //typeB.MyFun01(); // TypeB --> static binding [early binding] method call based on reference type
            //typeB.MyFun02(); // TypeC --> dynamic binding [late binding] method call based on object type
            //typeB.A = 10;
            //typeB.B = 20;
            ////typeB.C = 30; // invalid

            //TypeA typeA = new TypeC(1, 2, 3); // typeA is indirect parent of TypeC
            //typeA.MyFun01(); // TypeA --> static binding [early binding] method call based on reference type
            //typeA.MyFun02(); // TypeC --> dynamic binding [late binding] method call based on object type
            //typeA.A = 10;
            //typeA.B = 20; // invalid
            //typeA.C = 30; // invalid

            //TypeA typeA = new TypeE(1 , 2 , 3 , 4 , 5);
            //TypeB typeB = new TypeE(1 , 2 , 3 , 4 , 5);
            //TypeC typeC = new TypeE(1 , 2 , 3 , 4 , 5);


            //typeA.MyFun01(); // i am parent
            //typeA.MyFun02(); // the last override before ending the current sequence TypeC 
            //Console.WriteLine("**************************************");
            //typeB.MyFun01();// i am child
            //typeB.MyFun02(); // the last override before ending the current sequence TypeC 
            //Console.WriteLine("**************************************");
            //typeC.MyFun01(); // i am grand child
            //typeC.MyFun02();// the last override before ending the current sequence TypeC 
            //Console.WriteLine("**************************************");


            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //typeD.MyFun01(); // i am child of grand child
            //typeD.MyFun02(); // the last override before ending the current sequence TypeE

            #endregion

            #region Interface

            //IMyType myType = new MyType(); // invalid
            // you can't create object from interface
            //IMyType myType;
            // you can create reference from interface
            // reference located in stack 4 bytes
            // refer to null

            // this reference can refer to any class implement this interface

            //IMyType myType = new MyType();
            //myType.Id = 10;
            //myType.MyFun(20);
            //myType.Print(); // only way to access default implemented method 

            #endregion

            #region Interface Example 2
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //ProcessSeries(seriesByTwo);
            
            //SeriesByThree seriesByThree = new SeriesByThree();
            //ProcessSeries(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour();
            //ProcessSeries(seriesByFour);
            #endregion
        }
    }
}
