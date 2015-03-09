//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using 
//the appropriate data types and descriptive names.

using System;
    class BankData
    {
        static void Main()
        {
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Middle Name:");
            string middleName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Bank Balance:");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Bank Name:");
            string bankName = Console.ReadLine();

            Console.WriteLine("IBAN:");
            string iban = Console.ReadLine();

            Console.WriteLine("First Credit Card Number:");
            long firstCreditCard = long.Parse(Console.ReadLine());

            Console.WriteLine("Second Credit Card Number:");
            long secondCreditCard = long.Parse(Console.ReadLine());

            Console.WriteLine("Third Credit Card Number:");
            long thirdCreditCard = long.Parse(Console.ReadLine());

            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine("Name: {0}\nBalance: {1}\nBank Name: {2}\nIBAN: {3}\nFirst Credit Card: {4}\nSecond Credit Card: {5}\nThird Credit Card: {6}", fullName, balance, bankName, iban, firstCreditCard, secondCreditCard ,thirdCreditCard);
                
        }
    }
