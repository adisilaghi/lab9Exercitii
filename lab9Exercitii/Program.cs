// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using lab9Exercitii;

CurrentAccount currentAccount = new CurrentAccount();
currentAccount.Id();
currentAccount.SeeBalance();
currentAccount.AddMoney(100);
currentAccount.GetMoney(4900);
currentAccount.SeeBalance(); 

SavingsAccount savingsAccount = new SavingsAccount();
savingsAccount.Id();
savingsAccount.SeeBalance();
savingsAccount.AddMoney(77 , 0.05);
savingsAccount.SeeBalance();

InvestmentAccount investmentAccount = new InvestmentAccount(24);
investmentAccount.Id();
investmentAccount.AddMoney(300);
investmentAccount.SeeBalance();
investmentAccount.GetMoney(2000);

