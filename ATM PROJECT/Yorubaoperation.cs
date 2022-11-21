using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM_PROJECT
{
    public class UserYoruba
    {

        public string? Pin { get; set; }
        public string? Name { get; set; }
        public decimal Balance { get; set; }
        public string? Account { get; set; }
    }



    public class AppYoruba
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

            Console.WriteLine("Tẹ PIN oni-nọmba mẹrin rẹ sii");
            var enter_pin = Console.ReadLine();

            var user = users.FirstOrDefault(x => x.Pin == enter_pin);
            if (user is not null)
            {
                while (true)
                {


                    Console.WriteLine($"Kaabo {user.Name} {user.Balance} ");

                    Console.WriteLine("Tẹ 1 lati ṣayẹwo iwọntunwọnsi, 2 lati yọ kuro, 3 lati gbe lọ, 4 lati ṣafihan gbogbo awọn akọọlẹ, 5 lati jade");
                    var check_option = Console.ReadLine();
                    if (check_option == "1")
                    {

                        Console.WriteLine($"iwontunwonsi: ${user.Balance}");
                        Console.WriteLine("Press any key to go to main menu");

                        Console.ReadKey();
                        continue;
                    }
                    else if (check_option == "2")
                    {
                        WithdrawalYoruba withd = new WithdrawalYoruba();
                        Console.WriteLine($"{withd.Cashdrawal(user)}");
                        Console.WriteLine("Tẹ bọtini eyikeyi lati lọ si akojọ aṣayan akọkọ");

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
                            Console.WriteLine(TransferYoruba.InitiateTransfer(user, reciver));
                            Console.WriteLine("Tẹ bọtini eyikeyi lati lọ si akojọ aṣayan akọkọ");

                            Console.ReadKey();
                            continue;

                        }
                        else
                        {
                            Console.WriteLine("account does not exist");
                            Console.WriteLine("Tẹ bọtini eyikeyi lati lọ si akojọ aṣayan akọkọ");

                            Console.ReadKey();
                            continue;
                        }

                    }
                    else if (check_option == "4")
                    {
                        users.ForEach(user => Console.WriteLine($"orukọ olumulo: {user.Name} nọmba ifowopamọ: {user.Account} Iwontunwonsi: {user.Balance}\n"));
                        Console.WriteLine("Tẹ bọtini eyikeyi lati lọ si akojọ aṣayan akọkọ");
                        Console.ReadKey();
                        continue;
                    }
                    else if (check_option == "5")
                    {
                        Console.WriteLine("O ṣeun fun yiyan wa! Eni a san e o.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("o yan aṣayan aiṣedeede");
                        Console.WriteLine("Tẹ bọtini eyikeyi lati lọ si akojọ aṣayan akọkọ");

                        Console.ReadKey();
                        continue;
                    }

                }
            }


        }
    }

    class WithdrawalYoruba
    {
        public string Cashdrawal(User user)
        {


            Console.WriteLine("Tẹ iye lati yọkuro");

            decimal with_bln = Convert.ToDecimal(Console.ReadLine());
            if (user.Balance >= with_bln)
            {

                user.Balance -= with_bln;

                return $"Ayọkuro ni aṣeyọri ${with_bln} titun iwontunwonsi ${user.Balance}";
            }
            return "Aini iwọntunwọnsi";



        }

    }

    public class TransferYoruba
    {
        public static string InitiateTransfer(User sender, User receiver)
        {
            Console.WriteLine("Elo ni o fẹ lati gbe");
            decimal maketransfer = Convert.ToDecimal(Console.ReadLine());
            if (sender.Account == receiver.Account)
                return "O ko le ṣe gbigbe funrararẹ";
            if (sender.Balance >= maketransfer)
            {
                receiver.Balance += maketransfer;
                sender.Balance -= maketransfer;
                return $"Gbigbe ni aṣeyọri {maketransfer} ti a rán lati {sender.Name} si {receiver.Name}";

            }

            return "insufficient iwontunwonsi";
        }

    }




}
