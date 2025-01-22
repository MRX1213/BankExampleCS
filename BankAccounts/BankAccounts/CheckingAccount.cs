﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; private set; }

        public CheckingAccount(string accountNumber, string accountHolder, decimal initialBalance, decimal overdrawnLimit) :
                base(accountNumber, accountHolder, initialBalance)
        {
            OverdraftLimit = overdrawnLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Withdrawl amount must be positive");
            if (amount > Balance + OverdraftLimit) throw new InvalidOperationException("Overdrawn Limit exceeded");
            this.Withdraw(amount + OverdraftLimit);
        }
    }
}