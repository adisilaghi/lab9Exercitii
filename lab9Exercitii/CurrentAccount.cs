using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9Exercitii
{
    internal class CurrentAccount : BankAccounts
    {
        private int TotalMoney;
        private Guid AccountId;

        public CurrentAccount() : base()
        {
            TotalMoney = 3000;
            AccountId = Guid.NewGuid();
        }
        public void Id()
        {
            Console.WriteLine($"Current Account, ID: {AccountId}");
        }
      public void AddMoney(int amount)
        {
            this.TotalMoney += amount;
            Console.WriteLine($"Added {amount} to the account.");
        }
        public void SeeBalance()
        {
            Console.WriteLine($"Current Balance: {TotalMoney}");
        }
        public void GetMoney(int amount)
        {
            int overdraftLimit = 5000;

            if (TotalMoney + overdraftLimit >= amount)
            {
                if (TotalMoney >= amount)
                {
                    this.TotalMoney -= amount;
                    Console.WriteLine($"Retrieved {amount} from the account.");
                }
                else
                {
                    int remainingAmount = amount - TotalMoney;
                    this.TotalMoney = 0;
                    Console.WriteLine($"Retrieved {amount} from the account (including {remainingAmount} from overdraft).");
                }
            }
            else
            {
                Console.WriteLine("Unable to retrieve money. Exceeds overdraft limit.");
            }
        }
    }
}

