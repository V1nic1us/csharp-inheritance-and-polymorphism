using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_polymorphism.Entities
{
    internal class SavingsAccount: Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base( number,  holder,  balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void withdraw(double amount)
        {
            //if (amount > 0 || Balance > 0)
            //{
            //    Balance -= amount;
            //}
            base.withdraw(amount);
            Balance -= 2.0;
        }
    }
}
