using System;
using System.Collections.Generic;

namespace Observer
{
    abstract class Subject
    {
        private List<Observer> _LstObservers = new List<Observer>();
        public void Attach(Observer objObserver)
        {
            _LstObservers.Add(objObserver);
        }
        public void Detach(Observer objObserver)
        {
            _LstObservers.Remove(objObserver);
        }
        public void Notify()
        {
            foreach (Observer objObserver in _LstObservers)
            {
                objObserver.Update();
            }
        }
    }
}
