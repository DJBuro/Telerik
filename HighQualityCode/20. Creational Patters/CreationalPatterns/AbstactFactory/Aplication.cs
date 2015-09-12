using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactory
{
    class Application
    {
        static void Main()
        {
            GUIFactory aFactory = GUIFactory.getFactory();
            Button aButton = aFactory.createButton();
            aButton.caption = "Play";
            aButton.paint();
        }
    }
}
