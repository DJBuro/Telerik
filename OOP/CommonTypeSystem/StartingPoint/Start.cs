// Problem 1, 2, 3
namespace StartingPoint
{
    using System;

    class Start
    {
        static void Main()
        {
            var firstStudent = new Student("Pesho", "Peshov", 2442);
            var secondStudent = new Student("Pesho", "Peshov", 2443);

            //Console.WriteLine(firstStudent != secondStudent);
            //Console.WriteLine(firstStudent.CompareTo(secondStudent));

            //Student anotherStudent = (Student)firstStudent.Clone();
            //Console.WriteLine(anotherStudent.ToString());
        }
    }
}
