using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public decimal Balance {  get; private set; }
        public Account(string accountNumber, string accountHolder, decimal balance)
        { 
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount < 0) { throw new ArgumentException("Deposit amount must be positive"); }
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount < 0) { throw new ArgumentException("Withdraw amount must be positive"); }
            if (amount > Balance) { throw new InvalidOperationException("Insufficient funds"); }
            Balance -= amount;
        }

        public static List<Account> Accounts { get; private set; }
        public static void GenerateTestAccounts()
        {
            Accounts = new List<Account>();
            Accounts.Add(new SavindsAccount("1001", "Alice", 1000, 0.03m));
            Accounts.Add(new SavindsAccount("1002", "Bob", 2000, 0.05m));
        }
    }
}
