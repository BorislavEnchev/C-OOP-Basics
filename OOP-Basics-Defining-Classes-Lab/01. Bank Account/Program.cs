using System;

namespace _01._Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.ID = 1;
            bankAccount.Balance = 15;

            Console.WriteLine($"Account {bankAccount.ID}, balance {bankAccount.Balance}");
        }
    }
}
