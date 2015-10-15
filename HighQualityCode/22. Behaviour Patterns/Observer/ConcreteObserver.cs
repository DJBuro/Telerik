using System;

namespace Observer
{
    class ConcreteObserver : Observer
    {
        private string _name;
        private string _LstObserverstate;
        private ConcreteSubject _subject;

        public ConcreteObserver(

          ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _LstObserverstate = _subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
              _name, _LstObserverstate);
        }

        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
