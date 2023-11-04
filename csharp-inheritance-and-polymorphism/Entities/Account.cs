using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_polymorphism.Entities
{
    internal class Account
    {
        public int Number {  get; protected set; }
        public string Holder { get; protected set; } = "";
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        { 
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void withdraw(double amount)
        {
            if (amount > 0 || Balance > 0)
            {
                Balance -= amount + 5;
            }
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }
    }
}
