namespace BankTest
{
    using System;

    public class LoanAccount : Account
    {
        private string custumer;
        private decimal balance;
        private decimal interestRate;
        private int period;
        private AccountType type;

        public LoanAccount(string name, decimal balance, decimal interestRate, AccountType type, int period)
        {
            this.custumer = name;
            this.balance = balance;
            this.interestRate = interestRate;
            this.period = period;
            this.type = type;
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
            get
            {
                return this.period;
            }
            set
            {
                this.period = value;
            }
        }

        public override AccountType Type
        {
            get { return this.type; }
        }
        public override void Deposit(decimal deposit)
        {
            this.balance -= deposit;
        }

        public override decimal CalculateInterestRate()
        {
            if (type == AccountType.Company)
            {
                if (this.period <= 2)
                {
                    return 0;
                }
                else
                {
                    return this.interestRate * (this.period - 2);
                }
            }
            else
            {
                if (this.period <= 3)
                {
                    return 0;
                }
                else
                {
                    return interestRate * (this.period - 3);
                }
            }
        }
    }
}
