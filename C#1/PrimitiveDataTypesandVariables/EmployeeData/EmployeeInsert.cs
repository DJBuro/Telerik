//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.using System;

using System;
class EmployeeInsert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Age (0-100):");
            short age = Convert.ToInt16(Console.ReadLine());
            while (age < 0 || age > 100) 
            {
                Console.WriteLine("{0} is not a valid", age);
                Console.WriteLine("Please enter 0-100");
                age = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Gender:");
            char gender = char.Parse(Console.ReadLine());
            while (gender != 'm' && gender != 'f')
            {
                Console.WriteLine("{0} is not a valid", gender);
                Console.WriteLine("Please enter f or m");
                gender = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your Personal ID number is:");
            long iDNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Your Unique employee number is:");
            long uniqueNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} \nAge: {2}\nGender: {3} \nPersonal ID: {4}\nUnique employee number: {5}",
                firstName, lastName, age, gender, iDNumber, uniqueNumber);
            }
        }
