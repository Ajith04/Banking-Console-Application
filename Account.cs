using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Console_Application
{
    internal class Account
    {
        public int customerID;
        public int accountNumber;
        public int balance;
        public string accountType;


        Customer customer = new Customer();

        public void deposit()
        {
            Console.Clear();
            Console.WriteLine("Enter an account number to deposit");
            int accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount to deposit");
            int amount = Convert.ToInt32(Console.ReadLine());

            Account found = customer.account.Find( a => a.accountNumber == accno);
            found.balance += amount;

            Console.WriteLine($"{amount} successfully credited to {accno}");
            Console.WriteLine($"New balance is {found.balance}");
            Console.ReadLine();

        }

        public void withdraw()
        {
            Console.Clear();
            Console.Write("Enter an account number to deposit");
            int accno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount to deposit");
            int amount = Convert.ToInt32(Console.ReadLine());

            Account found = customer.account.Find(a => a.accountNumber == accno);

            found.balance -= amount;

            Console.WriteLine($"{amount} successfully deducted from {accno}");
            Console.WriteLine($"New balance is {found.balance}");
            Console.ReadLine();
        }

        public void getBalance()
        {
            Console.Clear();
            Console.Write("Enter an account number ");
            int accno = Convert.ToInt32(Console.ReadLine());
           
            Account found = customer.account.Find(a => a.accountNumber == accno);
            Console.WriteLine(found.balance);

            Console.ReadLine();
        }

        public void transfer()
        {
            Console.Clear();
            Console.Write("Account number - From : ");
            int fromAccNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Account number - To : ");
            int toAccNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an amount to transfer : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Account final1 = customer.account.Find(a => a.accountNumber == fromAccNo);

            final1.balance -= amount;

            Account final2 = customer.account.Find(a => a.accountNumber == toAccNo);

            final2.balance += amount;

            Console.WriteLine("Successfully transferd the amount");

            Console.ReadLine();
        }

    }
}
