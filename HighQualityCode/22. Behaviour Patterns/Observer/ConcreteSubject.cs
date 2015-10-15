using System;
using System.Collections.Generic;

namespace Observer
{
    class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
