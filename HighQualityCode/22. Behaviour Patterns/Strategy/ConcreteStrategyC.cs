using System;

namespace Strategy
{
    class ConcreteStrategyC : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyC.Execute()");
        }
    }
}
