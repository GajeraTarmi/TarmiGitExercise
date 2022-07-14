using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {

            get
            {
                decimal balance = 0;
                foreach (var i in allTransactions)
                {
                    balance += i.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;
        public List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposite must be positive");
            }
            var deposite = new Transaction(amount, date, note);
            allTransactions.Add(deposite);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient balance for this withdrawal");
            }
            var withdraw = new Transaction(-amount, date, note);
            allTransactions.Add(withdraw);
        }


        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote");

            foreach (var i in allTransactions)
            {
                report.AppendLine($"{i.Date.ToShortDateString()}\t{i.Amount}\t{i.Notes}");
            }

            return report.ToString();
        }
        
    }
}
