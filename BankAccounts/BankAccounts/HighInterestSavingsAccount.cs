using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class HighInterestSavingsAccount : SavindsAccount
    {
        public HighInterestSavingsAccount(string accountNumber, string accountHolder, decimal initialBalance, decimal interestRate) :
            base(accountNumber, accountHolder, initialBalance, interestRate)
        {

        }

        public void ApplyInterest(decimal bonusRate)
        {
            decimal bonusInterestPayment = this.Balance * bonusRate;
            this.Deposit(bonusInterestPayment);
        }
    }
}
