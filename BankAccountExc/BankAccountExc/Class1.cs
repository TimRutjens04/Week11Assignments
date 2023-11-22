using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExc
{
    internal class BankAccount
    {
        internal double balance;

        public BankAccount() { balance = 0; }

        public double Balance { get { return balance; } }
        public void Deposit(double amount) 
        {
            balance += amount;
        }
        public bool Withdraw(double amount) 
        {
            if (amount > balance) 
            { return false; }
            balance -= amount;
            return true; 
        }

    }
}
