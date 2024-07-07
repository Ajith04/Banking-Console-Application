using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Console_Application
            
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Program program = new Program();
            Account account = new Account();
            Bank bank = new Bank();


            bool repeat = true;

            while (repeat == true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create a Customer.");
                Console.WriteLine("2. Create an Account.");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Transfer Funds");
                Console.WriteLine("6. View Customer Details");
                Console.WriteLine("7. Exit");
                int userInput = Convert.ToInt32(Console.ReadLine());


                switch (userInput)
                {
                    case 1: program.createCustomer();
                        break;
                    case 2:program.createAccount();
                        break;
                    case 3: account.deposit();
                        break;
                    case 4: account.withdraw();
                        break;
                    case 5: account.transfer();
                        break;
                    case 6: bank.showCustomerDetails();
                        break;
                    case 7: repeat = false;
                        break;

                }
            }
        }

        
        public void createCustomer()
        {
            Bank bank = new Bank();

            bool crepeat = true;
            while (crepeat == true)
            {
                Console.Clear();
                Console.WriteLine("1. Add a Customer");
                Console.WriteLine("2. Remove a Customer");
                Console.WriteLine("3. Go back");

                int cinput = Convert.ToInt32(Console.ReadLine());

                switch (cinput)
                {
                    case 1:
                        bank.addCustomer();
                        break;
                    case 2: bank.removeCustomer();
                        break;
                    case 3: crepeat = false;
                        break;
                }
            }

        }

        public void createAccount()
        {

            Customer customer = new Customer();

            bool arepeat = true;
            while (arepeat == true)
            {
                Console.Clear();
                Console.WriteLine("1. Add an account.");
                Console.WriteLine("2. Remove an account.");
                Console.WriteLine("3. Get account details.");
                Console.WriteLine("4. Go back");

                int ainput = Convert.ToInt32(Console.ReadLine());

                switch (ainput)
                {
                    case 1: customer.addAccount();
                        break;
                    case 2: customer.removeAccount();
                        break;
                    case 3: customer.getAccountDetails();
                        break;
                    case 4: arepeat = false;
                        break;
                }
            }
        }

    }
}
