using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PROJECT
{
    /*public class WithdrawalEventArgs : EventArgs
    {

        public User user { get; set; }
    }*/

    public class Withdrawal
    {
        public delegate void withdrawdelegate(object source, EventArgs e);
        public event withdrawdelegate withdrawhandler;
/*        public event EventHandler<WithdrawalEventArgs> Onwithdrawal;
*/
        
        public void Cashdrawal(User user)
        {
                
                
                Console.WriteLine("Enter amount to withdraw");

                decimal with_bln = Convert.ToDecimal(Console.ReadLine());
                if (user.Balance >= with_bln)
                {

                   user.Balance -= with_bln;

                    Console.WriteLine( $"Successfully withdrawn ${with_bln} new balace ${user.Balance}");
                }

            

            Console.WriteLine("Insufficient balance");
            Withdrawalprocess(user);

        }

        protected virtual void Withdrawalprocess(User user)
        {

            withdrawhandler?.Invoke(this, EventArgs.Empty);

        }
         
}
}
