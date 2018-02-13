using System;

namespace _02._Bank_Account_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();

            bankAccount.Id = 1;
            bankAccount.Deposit(15);
            bankAccount.Withdraw(10);

            Console.WriteLine(bankAccount);
        }
    }
}
