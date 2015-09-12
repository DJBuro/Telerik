using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    public abstract class Account : IAcounts
    {
        private string custumer;
        private decimal balance;
        private decimal interestRate;
        private int period;
        private AccountType type;

        public abstract string Custumer { get; set; }

        public abstract decimal Balance { get; set; }

        public abstract decimal InterestRate { get; set; }

        public abstract int Period { get; set; }

        public abstract AccountType Type { get; }

        public virtual void Deposit(decimal deposit)
        {
            this.balance += deposit;
        }

        public virtual decimal CalculateInterestRate()
        {
            return this.interestRate * this.period;
        }
    }
}
