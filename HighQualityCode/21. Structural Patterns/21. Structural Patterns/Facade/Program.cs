using System;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            SubsystemA a = new SubsystemA();
            SubsystemB b = new SubsystemB();
            SubsystemC c = new SubsystemC();

            Operation1(a, b);
            Operation2(b, c);
        }

        static void Operation1(SubsystemA a, SubsystemB b)
        {
            Console.WriteLine("Operation 1\n" + a.OperationA1() + a.OperationA2() + b.OperationB1());
        }

        static void Operation2(SubsystemB b, SubsystemC c)
        {
            Console.WriteLine("Operation 2\n" + b.OperationB2() + c.OperationC1() + c.OperationC2());
        }
    }
}
