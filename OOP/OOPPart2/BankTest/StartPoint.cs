namespace BankTest
{
    using System;

    public class StartPoint
    {
        static void Main()
        {
            Account[] bankSystem = 
            {
                new DepositAccount("Pesho", 333.33m, 0.1m, 20),
                new LoanAccount("Gosho", 2000.33m, 0.1m, AccountType.Company, 14),
                new MortageAccount("Stamat", 4003m, 0.1m, AccountType.Company, 3),
                new DepositAccount("Mariq", 3333.33m, 0.1m, 2),
                new LoanAccount("Lili", 6666.33m, 0.1m, AccountType.Individual, 4),
                new MortageAccount("Irena", 444.33m, 0.1m, AccountType.Individual, 12),
                new DepositAccount("Poli", 1000000.33m, 0.2m, 23)
            };

            foreach (var item in bankSystem)
            {
                Console.WriteLine(item.CalculateInterestRate());
            }
        }
    }
}
