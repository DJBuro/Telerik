using System;

namespace AbstactFactory
{
    class OSXFactory : GUIFactory
    {
        public override Button createButton()
        {
            return (new OSXButton());
        }
    }

}
