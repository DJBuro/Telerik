using System;

namespace Decorator
{
    class DecoratorB : IComponent
    {
        IComponent component;
        public string addedState = "past the Coffee Shop ";


        public DecoratorB(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "to school "; 
            return s;
        }

        public string AddedBehavior() 
        {
            return "and I bought a cappuccino ";
        }
    }
}
