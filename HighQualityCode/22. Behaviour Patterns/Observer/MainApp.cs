using System;
using System.Collections.Generic;

namespace Observer
{
    class MainApp
    {
        static void Main()
        {
            ConcreteSubject objConcreteSubject = new ConcreteSubject();
            objConcreteSubject.Attach(new ConcreteObserver(objConcreteSubject, "X"));
            objConcreteSubject.Attach(new ConcreteObserver(objConcreteSubject, "Y"));
            objConcreteSubject.Attach(new ConcreteObserver(objConcreteSubject, "Z"));
            objConcreteSubject.SubjectState = "ABC";
            objConcreteSubject.Notify();
            objConcreteSubject.SubjectState = "DEF";
            objConcreteSubject.Notify();
        }
    }
}