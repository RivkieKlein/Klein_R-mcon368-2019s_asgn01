using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EligibilityLibrary;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length==0)
            {
                getInput();
            }
            else
            {
                Boolean citizen = false;
                if (args[0].Equals("true"))
                {
                    citizen = true;
                }
                int age = Convert.ToInt16(args[1]);
                int yearsResiding = Convert.ToInt16(args[2]);
                Boolean rebel = false;
                if (args[3].Equals("true"))
                {
                    rebel = true;
                }
                sendResults(Class1.eligible(citizen, age, yearsResiding, rebel));
            }
        }

        static void getInput()
        {
            Console.WriteLine("Are you a natural born citizen? true/false");
            String cit = Console.ReadLine();
            Boolean citizen;
            if (cit.Equals("true"))
            {
                citizen = true;
            }
            else
            {
                citizen = false;
            }

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("For how many years have you been a resident of the US");
            int yearsResiding = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Have you ever rebelled against the United States of America? true/false");
            String reb = Console.ReadLine();
            Boolean rebel;
            if (reb.Equals("true"))
            {
                rebel = true;
            }
            else
            {
                rebel = false;
            }

            sendResults(Class1.eligible(citizen, age, yearsResiding, rebel));

            
        }

        static void sendResults(Boolean eligible)
        {
            if (eligible)
            {
                Console.WriteLine("You are eligible to run for president! Throw your hat in the ring and give it a try!");
            }
            else
            {
                Console.WriteLine("You are not eligible to run for president. Sorry :(");
            }
        }
    }
}
