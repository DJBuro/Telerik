using System;

namespace Decorator
{
    class DecoratorA : IComponent
    {
        IComponent component;

        public DecoratorA(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "and listening to Classic FM "; 
            return s;
        }
    }
}
