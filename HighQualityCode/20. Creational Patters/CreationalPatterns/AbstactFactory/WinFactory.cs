using System;

namespace AbstactFactory
{
    class WinFactory : GUIFactory
    {
        public override Button createButton()
        {
            return (new WinButton());
        }
    }
}
