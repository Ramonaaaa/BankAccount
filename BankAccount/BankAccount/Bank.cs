using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public static class Bank
    {
        public static void TransferMoney(Account sourceAccount, Account destinationAccount, decimal amount)
        {
            if (sourceAccount.IsActive && destinationAccount.IsActive)
            {
                if (sourceAccount.TotalAmount >= amount)
                {
                    sourceAccount.Withdrawals(amount);
                    destinationAccount.DepositMoney(amount);
                    Console.WriteLine("The transaction was successful!");
                }

                else
                {
                    Console.WriteLine("Sorry, you don't have enough money for the transaction!");
                }
            }
            else
            {
                Console.WriteLine("One of the accounts is not active!");
            }
        }
    }
}
