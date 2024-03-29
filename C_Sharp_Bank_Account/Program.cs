﻿using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("<Creg>", 1000);
            Console.WriteLine($"Account # {account.Number}  was created for {account.Owner} with ${account.Balance} dollars initial balance.");
        }
    }

    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
