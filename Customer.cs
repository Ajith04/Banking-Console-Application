using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Console_Application
{
    
    internal class Customer
    {
        public int customerID;
        public string name;
        public string email;





        public List<Account> account = new List<Account>();
        Bank bank = new Bank();

        public Customer(int cid, string cname, string cemail)
        {
            customerID = cid;
            name = cname;
            email = cemail;
        }

        public Customer()
        {

        }


        public void addAccount()
        {
            Console.Clear();
            Console.Write("Enter customer ID : ");
            int custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an account number : ");
            int accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Savings 2. Checking");
            int acctype = Convert.ToInt32(Console.ReadLine());

            if (bank.customer.Exists(a => a.customerID == custid))
            {
                if (acctype == 1)
                {
                    account.Add(new Savings(custid, accno, "Savings"));
                    Console.WriteLine("Successfully added to Savings");
                }
                else if (acctype == 2)
                {
                    account.Add(new Checking(custid, accno, "Checking"));
                    Console.WriteLine("Successfully added to Checking");

                }
            }
            else
            {
                Console.WriteLine("The customer ID does not found in records");

            }

            Console.ReadLine();

        }

        public void removeAccount()
        {
            Console.Clear();
            Console.Write("Enter an Account number to remove : ");
            int accno = Convert.ToInt32(Console.ReadLine());

            if (account.Exists(a=>a.accountNumber == accno))
            {
                account.Remove(account.Find(a=> a.accountNumber == accno));
                Console.WriteLine("Successfully removed");
            }
            else
            {
                Console.WriteLine("There is no match");
            }
            Console.ReadLine();

        }

        public void getAccountDetails()
        {
            Console.Clear();
            Console.Write("Enter an Account number to search : ");
            int accno = Convert.ToInt32(Console.ReadLine());

            if (account.Exists(a => a.accountNumber == accno))
            {
                var filtered = from a in account where a.accountNumber == accno select a;
                foreach(var a in filtered)
                {
                    Console.WriteLine($"Customer ID : {a.customerID}\nAccount Number : {a.accountNumber}\nAccount Type : {a.accountType}\nBalance : {a.balance}");                }
            }
            else
            {
                Console.WriteLine("There are no any account for this account number");
            }
            Console.ReadLine();
        }
    }
}
