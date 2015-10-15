using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        IStrategy strategy;
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void UpdateContext(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Execute();
        }
    }
}
