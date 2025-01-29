using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class SavindsAccount : Account
    {
        public decimal InterestRate { get; private set; }
        public SavindsAccount(string accountNumber, string accountHolder, decimal initialBalance, decimal interestRate) :
            base(accountNumber, accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            decimal interestPayment = Balance * InterestRate;
            this.Deposit(interestPayment);
        }
    }
}
