using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class EmployeeMemento
    {
        private string _empName;
        private string _empID;
        private double _sal;
        public EmployeeMemento(string empName, string empID, double salary)
        {
            this._empName = empName;
            this._empID = empID;
            this._sal = salary;
        }
        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }
        public string EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }
        public double Salary
        {
            get { return _sal; }
            set { _sal = value; }
        }
    }
}
