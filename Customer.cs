using System;

namespace MySecondProject
{
    class Customer 
    {
        //Fields
        private string name;
        private string phoneNumber;
        private string address;
        private string email;
        private int accountNumber;
        private decimal accountBalance;


        //Public properties with getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        //Constructor
        public Customer(string name, string phoneNumber, string address, string email,
            int accountNumber, decimal accountBalance)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.email = email;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;

        }

        public void TransferMoney(decimal amount, Customer recipient)
        {
            if (amount <= accountBalance)
            {
                accountBalance -= amount;
                recipient.AccountBalance += amount;
                Console.WriteLine("Amount {0} has been transferred.", amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }


        public override string ToString()
        {
            return $"Name: {name}\nPhone number: {phoneNumber}\nAddress: {address}\nEmail: {email}\nAccount number: {accountNumber}\nBalance: {accountBalance}";
        }
    }
}
