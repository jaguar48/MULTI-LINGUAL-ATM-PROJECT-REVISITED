using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PROJECT
{
    internal class Withdrawal
    {
        public string Cashdrawal(User user)
        {
                
                
                Console.WriteLine("Enter amount to withdraw");

                decimal with_bln = Convert.ToDecimal(Console.ReadLine());
                if (user.Balance >= with_bln)
                {

                   user.Balance -= with_bln;

                    return $"Successfully withdrawn ${with_bln} new balace ${user.Balance}";
                }
            return "Insufficient balance";

                
           
        }
         
}
}
