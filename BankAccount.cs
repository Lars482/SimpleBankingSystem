using System;
namespace MySecondProject
{
    public class BankAccount
    {
        private decimal balance
        //private decimal initialBalance;

        {
            get { return balance; }
            set { balance = value; }
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

        public void DepositMoney(decimal amount) {
            if (amount > 0)
            {
                balance += amount;
            }

        }

      

        public void TransferMoney(decimal amount, decimal balance) {
            Console.WriteLine("How much do u want to withdraw? Your balance is {0}", balance);
            decimal.TryParse(Console.ReadLine(), out amount);
            if (amount <= balance)
            {
                Console.WriteLine("amount {0} has been withdrawn", amount);
            }
            else {

                Console.WriteLine("Insuffecient funds");

            }

        }

    }
}
