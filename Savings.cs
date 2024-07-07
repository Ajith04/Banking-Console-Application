using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Console_Application
{
    internal class Savings : Account
    {

        public Savings(int custID, int accNo, string accType)
        {
            customerID = custID;
            accountNumber = accNo;
            accountType = accType;
        }

    }
}
