using System;

namespace CsharpAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //uncommenting the following line demonstrates the error you receive when trying to instantiate an abstract class.
            //MyAbstractClass abClass = new MyAbstractClass();
            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();
            Console.Read();

        }

        //MyAbstractClass will serve as the base class for ClassA
        //to declare an abstract class, add the abstract keyword before the class keyword
        abstract class MyAbstractClass
        {
            private string message = "hello C#";
            public void PrintMessage()
            {
                Console.WriteLine(message);
            }
            //Declare an abstract Method inside an abstract class by using the abstract keyword before the return type
            //the PrintMessageAbstract() method below has no body and ends with a semi-colon. 
            //Abstract methods must be implemented in the derived class. for ex. 'ClassA'
            public abstract void PrintMessageAbstract(); 
        }

        class ClassA : MyAbstractClass
        {
            //ClassA derives/inherits from MyAbstractClass
            //to implement the PrintMessageAbstract() method below, use the override keyword.
            public override void PrintMessageAbstract()
            {
                Console.WriteLine("C# is fun and stuff.");
            }
        }
    }
}
