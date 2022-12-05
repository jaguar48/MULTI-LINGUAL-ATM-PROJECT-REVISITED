

using System;
using System.Collections.Generic;
using System.Collections;


namespace ATM_PROJECT
{
   


    class Program
    {

        public static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Motion Banking and Finance Limited! \nPress 1 for english, 2 for Igbo, 3 for Yoruba, 4 for exit");
            var Languageoption = Console.ReadLine();

            if (Languageoption != null)
            {
                while (true)
                {
                    if (Languageoption == "1")
                    {
                        App.Userrecords();
                    }
                    else if (Languageoption == "2")
                    {
                        AppIgbo.Userrecords();
                    }
                    else if (Languageoption == "3")
                    {
                        AppYoruba.Userrecords();
                    }
                    else if (Languageoption == "4")
                    {
                        Console.WriteLine("Thank you for choosing us");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }

                }




            }


        }
    }
    
}

