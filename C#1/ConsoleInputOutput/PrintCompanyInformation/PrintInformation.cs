//Problem 2. Print Company Information
//
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
class PrintInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter information about company and his manager!");
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Adress: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3}", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

