using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class MainApp
    {        
        static void Main()
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker(); 
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
