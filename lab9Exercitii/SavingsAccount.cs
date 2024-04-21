using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab9Exercitii
{
    internal class SavingsAccount :BankAccounts
    {
        private double TotalMoney;
        private Guid AccountId;
        public SavingsAccount() : base()
        {
            TotalMoney = 15000;
            AccountId = Guid.NewGuid();
        }
        public void Id()
        {
            Console.WriteLine($"\nSavings Account, ID: {AccountId}");
        }
      public void SeeBalance()
        {
            Console.WriteLine($"Current Balance: {TotalMoney}");
        }
        public void AddMoney(int amount, double interestRate)
        {
            double updatedAmount = amount * (1 + interestRate); 
            TotalMoney += updatedAmount;
            Console.WriteLine($"Added {amount} to the account with interest rate {interestRate:P}. Updated balance: {TotalMoney}");
        }

    }
}
