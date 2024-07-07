using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Banking_Console_Application
{
    internal class Bank
    {
        public List<Customer> customer = new List<Customer>();

        

        public void addCustomer()
        {
            Console.Clear();
            Console.WriteLine("Add Customer");
            Console.Write("Enter customer ID : ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter customer name : ");
            string cname = Console.ReadLine();
            Console.Write("Enter customer email : ");
            string cemail = Console.ReadLine();

           if (customer.Exists(c => c.customerID == cid))
            {
                Console.WriteLine("Customer ID already exists");
            }
            else
            {
                customer.Add(new Customer(cid, cname, cemail));
                Console.WriteLine("Successfully added.");
            }
            
            Console.ReadLine();

        }

        public void removeCustomer()
        {
            Console.Clear();
            Console.Write("Enter customer ID : ");
            int cid = Convert.ToInt32(Console.ReadLine());

            

            if (customer.Exists(c => c.customerID == cid))
            {
                customer.Remove(customer.Find(c => c.customerID == cid));
                Console.WriteLine("Successfully Removed.");
            }
            else
            {
                Console.WriteLine("The customer ID is not exists");
            }

            Console.ReadLine();
        }

        public void showCustomerDetails()
        {
            
            Console.Clear();
            Console.Write("Enter a Customer ID : ");
            int custid = Convert.ToInt32(Console.ReadLine());
            var cust = customer.Find(c => c.customerID == custid);

            Console.ReadLine();
            
        }
    }
}
