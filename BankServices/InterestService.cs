using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts;

namespace BankServices
{
    public class InterestService
    {
        public void AppliedInterestsToAccounts(List<Account> accounts)
        {
            foreach (var account in accounts)
            {
                if (account is SavindsAccount savingsAccount)
                {
                    savingsAccount.ApplyInterest();
                    Console.WriteLine($"Interest applied to SavingsAccount ({savingsAccount.AccountNumber}) New Balance is: {savingsAccount.Balance:C}");
                }

                if (account is HighInterestSavingsAccount highInterestSavingsAccount)
                {
                    highInterestSavingsAccount.ApplyInterest();
                    Console.WriteLine($"Bonus interest applied to SavingsAccount ({highInterestSavingsAccount.AccountNumber}) New Balance is: {highInterestSavingsAccount.Balance:C}");
                }
            }
        }
    }

}
