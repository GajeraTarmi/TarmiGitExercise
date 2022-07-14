using System;
using Bank_Account;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var account = new BankAccount("Tarmi", 1000);
            Console.WriteLine($"Account {account.Number} is created by {account.Owner} with initial balance {account.Balance}");
            account.MakeDeposit(10000, DateTime.Now, "Salary");
            Console.WriteLine($"Balance after getting salary : {account.Balance}");
            account.MakeWithdrawal(5000, DateTime.Now, "Foosball Table");
            Console.WriteLine($"Balance after buying foosBall Table : {account.Balance}");

            //account.MakeDeposit(-300,DateTime.Now,"handsfree");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
