namespace BankTest
{
    using System;

    public class DepositAccount : Account
    {
        private string custumer;
        private decimal balance;
        private decimal interestRate;
        private int period;
        private AccountType type;

        public DepositAccount(string name, decimal balance, decimal interestRate, int period)
        {
            this.custumer = name;
            this.balance = balance;
            this.interestRate = interestRate;
            this.period = period;
        }
        
        public override string Custumer
        {
            get
            {
                return this.custumer;
            }
            set
            {
                this.custumer = value;
            }
        }

        public override decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public override decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public override int Period
        {
            get { return this.period; }
            set { this.period = value; }
        }

        public override AccountType Type
        {
            get { return this.type; }
        }

        public override void Deposit(decimal deposit)
        {
            this.balance += deposit;
        }

        public void Withdraw(decimal withdraw)
        {
            this.balance -= withdraw;
        }

        public override decimal CalculateInterestRate()
        {
            if (balance > 1000 && balance < 0)
            {
                return 0;
            }
            else
            {
                return this.interestRate * this.period;
            }
        }
    }
}
