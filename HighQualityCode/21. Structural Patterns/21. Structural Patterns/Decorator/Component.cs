using System;

namespace Decorator
{
    class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking ";
        }
    }
}
