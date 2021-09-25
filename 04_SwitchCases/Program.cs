using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1; 

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("this is default. It will be executed if no other case is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It is the weekend!");
                    break;
            }

            //Challege
            // Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response for each value. If they respond out of range, let them know.

            Console.WriteLine("How are you feeling today, on a range of 1 to 5");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                case "0":
                    Console.WriteLine("Sorry to hear that");
                    break;
                case "2":
                case "2.5":
                    Console.WriteLine("Hope you get better");
                    break;
                case "3":
                    Console.WriteLine("Hang in there");
                    break;
                case "4":
                    Console.WriteLine("Not bad");
                    break;
                case "5":
                    Console.WriteLine("Great");
                    break;
                default:
                    Console.WriteLine("It loos like you entered an invalid input");
                    break;

            }
               





            Console.ReadKey();
        }
    }
}
