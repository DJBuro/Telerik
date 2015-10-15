using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Program
    {

        static void Display(string s, IComponent c)
        {

            Console.WriteLine(s + c.Operation());
        }


        static void Main()
        {
            Console.WriteLine("Decorator Pattern\n");

            IComponent component = new Component();
            Display("1. Basic component: ", component);
            Display("2. A-decorated : ", new DecoratorA(component));
            Console.ReadLine();
            Display("3. B-decorated : ", new DecoratorB(component));
            Console.ReadLine();
            Display("4. B-A-decorated : ", new DecoratorB(new DecoratorA(component)));
            Console.ReadLine();
            DecoratorB b = new DecoratorB(new Component());
            Display("5. A-B-decorated : ", new DecoratorA(b));
            Console.WriteLine("\t\t\t" + b.addedState + b.AddedBehavior());
            Console.ReadLine();
        }
    }
}