using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PROJECT
{
    public class Transfer
    {
        public static string InitiateTransfer(User sender, User receiver)
        {
            Console.WriteLine("How much do you want to transfer");
            decimal maketransfer = Convert.ToDecimal(Console.ReadLine());
            if (sender.Account == receiver.Account) 
                return "You cannot make transfer toself";
             if (sender.Balance >= maketransfer)
            {
                receiver.Balance += maketransfer;
                sender.Balance -= maketransfer;
                return $"Transfer successful {maketransfer} was sent from {sender.Name} to {receiver.Name}";

            }
            
            return "insufficient balance";
        }

    }
 
}
