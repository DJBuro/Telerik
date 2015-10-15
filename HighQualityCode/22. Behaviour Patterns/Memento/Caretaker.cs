using System;
namespace Memento
{
    class Caretaker
    {
        private EmployeeMemento _empInfo;
        public EmployeeMemento EmpMemento
        {
            set { _empInfo = value; }
            get { return _empInfo; }
        }
    }
}
