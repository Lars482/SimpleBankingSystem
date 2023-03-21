using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySecondProject;

class Program 
{
    static void Main(string[] args)
    {

       Customer customer1 = new Customer("Peter Larsen", "11223344", "Hannemanns alle 44f",
            "PeterLarsen@outlook.dk", 00001, 100000);

       Customer customer2 = new Customer("Carl Larsen", "55667788", "Strandvejen 11",
            "CarlLarsen@outlook.dk", 00002, 200000);

        Console.WriteLine(customer1.ToString() + "\n" + customer2.ToString());

     
        
        //customer1.TransferMoney(){
        BankAccount account1 = new BankAccount();
        // perform transfer

        customer1.TransferMoney(10000, customer2);


        // print updated balances
        // Print updated balances
        Console.WriteLine("Account 1 balance: {0}", customer1.AccountBalance);
        Console.WriteLine("Account 2 balance: {0}", customer2.AccountBalance);

    }
    
}



