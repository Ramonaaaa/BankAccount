using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Ramona Mihai", 1500);
            account.ActivateAccount();
            Console.WriteLine($"The account holder is: {account.Name}.");
            Console.WriteLine($"Your amount: {account.Money} Euros.");

            account.DepositMoney(118);
            Console.WriteLine($"Your total amount now is: {account.Money}.");

            account.Withdrawals(320);
            Console.WriteLine($"Your total amount after withdrawl is: {account.Money}.");

            account.Withdrawals(2015);

            Console.WriteLine("--------------------");

            Account sourceAccount = new Account("Ramona Mihai", 350);
            Account destinationAccount = new Account("Roxana", 128);
            destinationAccount.ActivateAccount();
            sourceAccount.ActivateAccount();

            Bank.TransferMoney(sourceAccount, destinationAccount, 200);

            Console.WriteLine("-------------------");

            
        }
    }
}
