using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace MySecondProject
{
	class Bank : IBank
	{
        private List<BankAccount> accounts;
        private List<Customer> customers;

        private Bank()
        {
            accounts = new List<BankAccount>();
            customers = new List<Customer>();
        }

        public bool getAccountId(BankAccount account)
        {
            try
            {
                if (account == null)
                {
                    throw new ArgumentNullException("account");
                }

                // code to get the account ID

                return true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
           

        }

        public bool WithdrawMoney(decimal amount)
        {
            try
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    return true;
                }

                else
                {
                    throw new InvalidOperationException("Insuffecient funds");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

        }

        public decimal balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }
   
   
}

