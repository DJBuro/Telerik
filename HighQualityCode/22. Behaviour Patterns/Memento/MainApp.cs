using System;

namespace Memento
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Originator org = new Originator();
            org.EmpID = "100";
            org.EmpName = "test";
            org.Salary = 2000;
            Console.WriteLine("Initial Emp Name:" + org.EmpName);
            Console.WriteLine("Initial Emp ID:" + org.EmpID);
            Console.WriteLine("Initial Emp Salary:" + org.Salary);
            Console.WriteLine("");
            Caretaker taker = new Caretaker();
            taker.EmpMemento = org.SaveState();

            org.EmpID = "101";
            org.EmpName = "test1";
            org.Salary = 3000;
            Console.WriteLine("Updated Emp Name:" + org.EmpName);
            Console.WriteLine("Updated Emp ID:" + org.EmpID);
            Console.WriteLine("Updated Emp Salary:" + org.Salary);
            Console.WriteLine("");

            org.RestoreState(taker.EmpMemento);
            Console.WriteLine("Rollbacked Emp Name:" + org.EmpName);
            Console.WriteLine("Rollbacked Emp ID:" + org.EmpID);
            Console.WriteLine("Rollbacked Emp Salary:" + org.Salary);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
