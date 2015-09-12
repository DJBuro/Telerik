namespace PersonClass
{
    using System;

    public class Start
    {
        static void Main()
        {
            var firstPerson = new Person { Name = "Pesho", Age = 22 };
            var secondPerson = new Person { Name = "Gosho" };

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
