using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM_PROJECT
{
    public class MyUser
    {

        public string? Pin { get; set; }
        public string? Name { get; set; }
        public decimal Balance { get; set; }
        public string? Account { get; set; }
    }

    


    public class AppIgbo
    {
        public static void Userrecords()
        {

            var users = new List<User>{
            new User {Name ="Stanley", Pin = "1111", Balance = 5000, Account = "234532"},
            new User {Name ="Okonkwo", Pin = "2222", Balance = 1000, Account = "145342"},
            new User {Name ="Paul", Pin = "3333", Balance = 3000, Account = "765543"},
            new User {Name ="Bishop", Pin = "4444", Balance = 2000, Account ="224422"},
            new User {Name ="Allen", Pin = "5555", Balance = 8000, Account = "345432"}

     };
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(@"Tinye ntụtụ ọnụọgụ anọ gị ");
            var enter_pin = Console.ReadLine();

            var user = users.FirstOrDefault(x => x.Pin == enter_pin);
            if (user is not null)
            {
                while (true)
                {


                    Console.WriteLine($"Nnoo {user.Name} {user.Balance} ");

                    Console.WriteLine("@Pịa 1 ka ịlele itule, 2 ịdọrọ, 3 ka ibufee, 4 ka igosipụta akaụntụ niile, 5 pụọ");
                    var check_option = Console.ReadLine();
                    if (check_option == "1")
                    {

                        Console.WriteLine($"itule: ${user.Balance}");
                        Console.WriteLine(@"Pịa igodo ọ bụla ka ịga na menu isi");

                        Console.ReadKey();
                        continue;
                    }
                    else if (check_option == "2")
                    {
                        WithdrawalIgbo withd = new WithdrawalIgbo();
                        Console.WriteLine($"{withd.Cashdrawal(user)}");
                        Console.WriteLine("Pịa igodo ọ bụla ka ịga na menu isi");

                        Console.ReadKey();
                        continue;

                    }
                    else if (check_option == "3")
                    {
                        Console.WriteLine("tinye nọmba akaụntụ nnata");
                        var Accountnumber = Console.ReadLine();
                        var reciver = users.FirstOrDefault(x => x.Account == Accountnumber);
                        if (reciver is not null)
                        {
                            Console.WriteLine(TransferIgbo.InitiateTransfer(user, reciver));
                            Console.WriteLine("Pịa igodo ọ bụla ka ịga na menu isi");

                            Console.ReadKey();
                            continue;

                        }
                        else
                        {
                            Console.WriteLine("akaụntụ adịghị");
                            Console.WriteLine("Pịa igodo ọ bụla ka ịga na menu isi");

                            Console.ReadKey();
                            continue;
                        }

                    }
                    else if (check_option == "4")
                    {
                        users.ForEach(user => Console.WriteLine($"aha njirimara: {user.Name} nọmba akaụntụ: {user.Account} itule: {user.Balance}\n"));
                        Console.WriteLine("Pịa igodo ọ bụla ka ịga na menu isi");

                        Console.ReadKey();
                        continue;
                    }
                    else if (check_option == "5")
                    {
                        Console.WriteLine("Daalụ maka ịhọrọ anyị! Nwee ụbọchị mara mma.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ị họrọla nhọrọ ezighi ezi");
                        Console.WriteLine("Pịa igodo ọ bụla ka ịga na menu isi");

                        Console.ReadKey();
                        continue;
                    }

                }
            }


        }
    }
     class WithdrawalIgbo
    {
        public string Cashdrawal(User user)
        {


            Console.WriteLine("Tinye ego iji wepụ");

            decimal with_bln = Convert.ToDecimal(Console.ReadLine());
            if (user.Balance >= with_bln)
            {

                user.Balance -= with_bln;

                return $"Ewepụrụ nke ọma ${with_bln} ọhụrụ itule ${user.Balance}";
            }
            return "Ntụziaka ezughi oke";



        }

    }
    public class TransferIgbo
    {
        public static string InitiateTransfer(User sender, User receiver)
        {
            Console.WriteLine("Ego ole ka ịchọrọ ibufe");
            decimal maketransfer = Convert.ToDecimal(Console.ReadLine());
            if (sender.Account == receiver.Account)
                return "Ị nweghị ike ịnyefe n'onwe gị";
            if (sender.Balance >= maketransfer)
            {
                receiver.Balance += maketransfer;
                sender.Balance -= maketransfer;
                return $"Nyefee gara nke ọma {maketransfer} e zigara ya {sender.Name} ka {receiver.Name}";

            }

            return "ezughi oke itule";
        }

    }
}
