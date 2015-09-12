using System;

namespace AbstactFactory
{
    class WinButton : Button
    {
        public override void paint()
        {
            Console.WriteLine("I'm a WinButton: " + caption);
        }
    }
}
