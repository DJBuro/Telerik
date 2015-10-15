using System;

namespace Strategy
{
    class MainApp
    {
        static void Main()
        {
            Context anObject;

            anObject = new Context(new ConcreteStrategyA());
            anObject.Execute();

            anObject.UpdateContext(new ConcreteStrategyB());
            anObject.Execute();

            anObject.UpdateContext(new ConcreteStrategyC());
            anObject.Execute();

        }
    }    
}
