using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PROJECT
{
    public class User
    {

        public string? Pin { get; set; }
        public string? Name { get; set; }
        public decimal Balance { get; set; }
        public string?  Account { get; set; }
    }



   public class App
    {
        public void Userrecords()
        {

            var users = new List<User>{
            new User {Name ="Stanley", Pin = "1111", Balance = 5000, Account = "234532"},
            new User {Name ="Okonkwo", Pin = "2222", Balance = 1000, Account = "145342"},
            new User {Name ="Paul", Pin = "3333", Balance = 3000, Account = "765543"},
            new User {Name ="Bishop", Pin = "4444", Balance = 2000, Account ="224422"},
            new User {Name ="Allen", Pin = "5555", Balance = 8000, Account = "345432"}

     };

            Console.WriteLine("Enter your 4 digit pin");
            var enter_pin = Console.ReadLine();

            var user = users.FirstOrDefault(x => x.Pin == enter_pin);
            if (user is not null)
            {
                while (true)
                {
                   

                    Console.WriteLine($"Welcome {user.Name} {user.Balance} ");

                    Console.WriteLine("Press 1 to check balance, 2 to withdraw, 3 to transfer, 4 to display all accounts, 5 to exit");
                    var check_option = Console.ReadLine();
                    if (check_option == "1")
                    {

                        Console.WriteLine($"balance: ${user.Balance}");
                        Console.WriteLine("Press any key to go to main menu");
                       
                        Console.ReadKey();
                        continue;   
                    }
                    else if (check_option == "2")
                    {
                       
                        var receipt = new ReceiptGen();
                        Withdrawal makewithdrawl = new Withdrawal();

                        makewithdrawl.withdrawhandler += receipt;

                        Console.WriteLine($"{withd.Cashdrawal(user)}");
                        Console.WriteLine("Press any key to go to main menu");
                        
                        Console.ReadKey();
                        continue;

                    }
                    else if (check_option == "3")
                    {
                        Console.WriteLine("enter receiver account number");
                        var Accountnumber = Console.ReadLine();
                        var reciver = users.FirstOrDefault(x => x.Account == Accountnumber);
                        if (reciver is not null)
                        {
                            Console.WriteLine(Transfer.InitiateTransfer(user, reciver));
                            Console.WriteLine("Press any key to go to main menu");
                            
                            Console.ReadKey();
                            continue;

                        }
                        else
                        {
                            Console.WriteLine("account does not exist");
                            Console.WriteLine("Press any key to go to main menu");
                           
                            Console.ReadKey();
                            continue;
                        }
            
                    }
                    else if (check_option == "4")
                    {
                        users.ForEach(user => Console.WriteLine($"user name: {user.Name} account number: {user.Account} Balance: {user.Balance}\n"));
                        Console.WriteLine("Press any key to go to main menu");

                        Console.ReadKey();
                        continue;
                    }
                    else if( check_option == "5")
                    {
                        Console.WriteLine("Thank you for choosing us! Have a nice day.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("you selected invalid option");
                        Console.WriteLine("Press any key to go to main menu");

                        Console.ReadKey();
                        continue;
                    }

                }
            }
           

        }
    }
}