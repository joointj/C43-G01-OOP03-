using Assignment;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Question 01
            /*
             * What is the primary purpose of an interface in C#?
                a) To provide a way to implement multiple inheritance
                b) To define a blueprint for a class
                c) To declare abstract methods and properties
                d) To create instances of objects

             */
            // Answer: b) To define a blueprint for a class
            #endregion
            #region Question 02
            /*
             * Which of the following is NOT a valid access modifier for interface members in C#?
                a) private
                b) protected
                c) internal
                d) public
             */
            // Answer: a) private
            #endregion
            #region Question 03
            /*
             * Can an interface contain fields in C#?
                a) Yes
                b) No
                c) Only if they are static
                d) Only if they are readonly
             */
            // Answer: b) No
            #endregion
            #region Question 04
            /*
             * In C#, can an interface inherit from another interface?
                a) No, interfaces cannot inherit from each other
                b) Yes, interfaces can inherit from multiple interfaces
                c) Yes, but only if they have the same methods
                d) Only if the interfaces are in the same namespace
             */
            // Answer: b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Question 05
            /*
             * Which keyword is used to implement an interface in a class in C#?
                a) inherit
                b) use
                c) extends
                d) implements
             */
            // Answer: d) implements
            // this is wrong question the right answer is :
            #endregion
            #region Question 06
            /*
             * Can an interface contain static methods in C#?
                a) Yes
                b) No
                c) Only if the interface is sealed
                d) Only if the methods are private
             */
            // Answer: b) Yes
            #endregion
            #region Question 07
            /*
             * In C#, can an interface have explicit access modifiers for its members?
                a) Yes, for all members
                b) No, all members are implicitly public
                c) Yes, but only for abstract members
                d) Only if the interface is sealed
             */
            // Answer: b) No, all members are implicitly public 
            // we can only use all access modifiers in the interface except private
            // with the default implemented methods which appears from C# 8.0
            // any other members implicitly public
            #endregion
            #region Question 08
            /*
             * What is the purpose of an explicit interface implementation in C#?
                a) To hide the interface members from outside access
                b) To provide a clear separation between interface and class members
                c) To allow multiple classes to implement the same interface
                d) To speed up method resolution
             */
            // Answer: b) To provide a clear separation between interface and class members
            // answer a is true by the primary purpose of explicit interface implementation
            // is to separate the interface members from the class members
            #endregion
            #region Question 09
            /*
             * In C#, can an interface have a constructor?
                a) Yes, but it must be private
                b) No, interfaces cannot have constructors
                c) Yes, but only if the interface is sealed
                d) Only if the constructor is static
             */
            // Answer: b) No, interfaces cannot have constructors
            #endregion
            #region Question 10
            /*
             * How can a C# class implement multiple interfaces?
                a) By using the "implements" keyword
                b) By using the "extends" keyword
                c) By separating interface names with commas
                d) A class cannot implement multiple interfaces
             */
            // Answer: c) By separating interface names with commas
            #endregion
            #endregion
            #region Part 02
            IShape rectangle = new Rectangle { Length = 10, Width = 5 };
            rectangle.DisplayShapeInfo();
            IShape circle = new Circle { Radius = 5 };
            circle.DisplayShapeInfo();
            #endregion
        }
    }
}
