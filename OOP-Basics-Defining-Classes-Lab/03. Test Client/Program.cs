using System;
using System.Collections.Generic;

namespace _03._Test_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var splitCmd = command.Split();
                var accID = int.Parse(splitCmd[1]);

                switch (splitCmd[0])
                {
                    case "Create":
                        if (accounts.ContainsKey(accID))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            var account = new BankAccount();
                            account.Id = accID;
                            accounts.Add(accID, account);
                        }
                        break;

                    case "Deposit":
                        if (ValidateAccountExists(accID, accounts))
                        {
                            accounts[accID].Deposit(int.Parse(splitCmd[2]));
                        }
                        break;

                    case "Withdraw":
                        if (ValidateAccountExists(accID, accounts))
                        {
                            accounts[accID].Withdraw(int.Parse(splitCmd[2]));
                        }
                        break;

                    case "Print":
                        if (ValidateAccountExists(accID, accounts))
                        {
                            Console.WriteLine(accounts[accID]);
                        }
                        break;
                }
            }
        }

        static bool ValidateAccountExists(int accID, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(accID))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Account does not exist");
                return false;
            }            
        }
    }
}
