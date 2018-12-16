using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Account
    {
        private decimal money;
        private readonly string name;
        private bool isActive;

        public decimal Money
        {
            get
            {
                return this.money;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        public decimal TotalAmount
        {
            get
            {
                return money;
            }
        }

        public Account(string name)
        {
            this.name = name;
        }

        public Account(string name, decimal initialMoney)
        {
            this.name = name;
            this.money = initialMoney;
        }

        public void ActivateAccount()
        {
            isActive = true;
        }
        
        public void DisableAccount()
        {
            isActive = false;
        }

        public bool Withdrawals(decimal amount)
        {
            if(isActive)
            {
                if (amount > money)
                {
                    Console.WriteLine("Sorry,you don't have enough money!");
                    return false;
                }
                else
                {
                    money = money - amount;
                    Console.WriteLine($"The amount of {amount} Euros has been successfully withdrawn!");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("The account is not active!");
                return false;
            }
        }

        public bool DepositMoney(decimal amount)
        {
            if(isActive)
            {
                money = money + amount;
                Console.WriteLine($"The amount of {amount} Euros has been successfully deposited!");
                return true;
            }
            else
            {
                Console.WriteLine("The account is not active!");
                return false;
            }
        }


    }
}
