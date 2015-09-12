using System;

namespace AbstactFactory
{
    abstract class GUIFactory
    {
        public static GUIFactory getFactory()
        {
            Console.WriteLine("Please enter 1 for windows ana 0 for anythin else!");
            int operationSystem = Console.Read();
            if (operationSystem == 49)
            {
                return (new WinFactory());
            }
            else
            {
                return (new OSXFactory());
            }
        }

        public abstract Button createButton();
    }
}
