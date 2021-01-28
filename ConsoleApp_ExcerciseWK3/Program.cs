using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ExerciseW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable list
            int monthNumber = 0;
            string monthName = "";
            string user = "";

            //output greeting
            Console.ForegroundColor = ConsoleColor.Green;
            user = Console.ReadLine();
            Console.WriteLine("Hi! Welcome to the Decision Calendar Program.");
            Console.ForegroundColor = ConsoleColor.Green;

            //inputs from user
            Console.ForegroundColor = ConsoleColor.Green;
            user = Console.ReadLine();
            Console.Write("_________________________________________________________________");
            user = Console.ReadLine();
            user = Console.ReadLine();
            Console.Write("Please enter the Month Number (1-12): ");
            monthNumber = Convert.ToInt32(Console.ReadLine());
            user = Console.ReadLine();

            //calculations 
            if (monthNumber == 1)
            {
                monthName = "1st Month... January!";
            }
            else if (monthNumber == 2)
            {
                monthName = "2nd Month... Feburary!";
            }
            else if (monthNumber == 3)
            {
                monthName = "3rd Month... March!";
            }
            else if (monthNumber == 4)
            {
                monthName = "4th Month... April!";
            }
            else if (monthNumber == 5)
            {
                monthName = "5th Month... May!";
            }
            else if (monthNumber == 6)
            {
                monthName = "6th Month... June!";
            }
            else if (monthNumber == 7)
            {
                monthName = "7th Month... July!";
            }
            else if (monthNumber == 8)
            {
                monthName = "8th Month... August!";
            }
            else if (monthNumber == 9)
            {
                monthName = "9th Month... September!";
            }
            else if (monthNumber == 10)
            {
                monthName = "10th Month... October!";
            }
            else if (monthNumber == 11)
            {
                monthName = "11th Month... November!";
            }
            else if (monthNumber == 12)
            {
                monthName = "12th Month... December!";
            }

            //outputs
            Console.Write("This is the " + monthName);
            user = Console.ReadLine();
            Console.Write("_________________________________________________________________");
            Console.ReadLine();
        }
    }
}
