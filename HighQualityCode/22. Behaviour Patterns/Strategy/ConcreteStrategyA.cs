using System;

namespace Strategy
{
    class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyA.Execute()");
        }
    }
}
