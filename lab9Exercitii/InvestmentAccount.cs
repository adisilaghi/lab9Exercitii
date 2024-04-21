using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9Exercitii
{
    internal class InvestmentAccount :BankAccounts
    {
        private int TotalMoney;
        private int WithdrawalDay;
        private Guid AccountId;
        public InvestmentAccount(int withdrawalDay) : base()
        {
            TotalMoney = 5000;
            WithdrawalDay = withdrawalDay;
            AccountId = Guid.NewGuid();
        }
        public void Id()
        {
            Console.WriteLine($"\nInvestment Account, ID: {AccountId}");
        }
        
        public void AddMoney(int amount)
        {
            TotalMoney += amount;
            Console.WriteLine($"Added {amount} to the account. Updated balance: {TotalMoney}");
        }

        public void SeeBalance()
        {
            Console.WriteLine($"Current Balance: {TotalMoney}");
        }
        public void GetMoney(int amount)
        {
            int currentDay = DateTime.Now.Day;
            Console.WriteLine($"Current day: {currentDay}, Withdrawal day: {WithdrawalDay}");
            if (currentDay < WithdrawalDay)
            {
                Console.WriteLine($"Cannot withdraw money before the specified withdrawal day ({WithdrawalDay}).");
            }
            else if (currentDay > WithdrawalDay)
            {
                Console.WriteLine($"Cannot withdraw money after the specified withdrawal day ({WithdrawalDay}).");
            }
            else
            {
                if (TotalMoney >= amount)
                {
                    this.TotalMoney -= amount;
                    Console.WriteLine($"Retrieved {amount} from the account. Updated balance: {TotalMoney}");
                }
                else
                {
                    Console.WriteLine($"Retrieved {amount}. Insufficient funds.");
                }
            }
        }

    }
}
