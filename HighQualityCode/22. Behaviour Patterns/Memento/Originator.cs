using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        private string _empName;
        private string _empID;
        private double _sal;

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value;}
        }

        public string EmpID
        {
            get { return _empID; }
            set { _empID = value;}
        }

        public double Salary
        {
            get { return _sal; }
            set { _sal = value;}
        }

        public void RestoreState(EmployeeMemento empMemento)
        {
            Console.WriteLine("Restoring State");
            this.EmpID = empMemento.EmpID;
            this.EmpName = empMemento.EmpName;
            this.Salary = empMemento.Salary;
        }

        public EmployeeMemento SaveState()
        {
            Console.WriteLine("Saving State");
            return new EmployeeMemento(_empName, _empID, _sal);
        }
    }
}
