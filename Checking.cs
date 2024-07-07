using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Console_Application
{
    internal class Checking :Account
    {

        public Checking(int custID, int accNo, string accType)
        {
            customerID = custID;
            accountNumber = accNo;
            accountType = accType;

        }
    }
}
