

using System;
using System.Collections.Generic;
using System.Collections;


namespace ATM_PROJECT
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Press 1 for english, 2 for Igbo, 3 for Yoruba");
            var Languageoption = Console.ReadLine();
            if (Languageoption != null)
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
            }
            else
            {
                Console.WriteLine("Incorrect, please select from options");
            }


            

        }
    }
    
}

