using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PROJECT
{
    internal class Balance
    {   
        public int Userbalance()
        {
            Random objRandom = new Random();
            int intValue = objRandom.Next(10000, 99999);
            int balance = intValue;
            return balance;
        }
      
    }
}
