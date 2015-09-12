using System;

namespace AbstactFactory
{
    class OSXButton : Button
    {
        public override void paint()
        {
            Console.WriteLine("I'm a OSXButton: " + caption);
        }
    }
}
