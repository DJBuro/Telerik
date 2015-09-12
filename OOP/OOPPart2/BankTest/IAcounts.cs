namespace BankTest
{
    using System;
    public interface IAcounts
    {
        string Custumer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        int Period { get; set; }

        void Deposit(decimal deposit);
        decimal CalculateInterestRate();
    }
}
