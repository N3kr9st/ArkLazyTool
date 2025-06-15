using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ArkLazyTool;

namespace ArkLazyTool
{
    internal class Menu
    {
        private static short UserInput()
        {
            string userInput;
            short choice;
            while (true)
            {
                Console.Write("Please select an option: ");
                userInput = Console.ReadLine() ?? "0";
                if (!short.TryParse(userInput, out choice))
                {
                    Console.WriteLine("Input is not an integer! Please try again.");
                    continue;
                }
                if (choice == 0)
                {
                    Console.WriteLine("Wrong input pls try again!");
                    continue;
                }
                if (choice is not 1 or 2)
                {
                    Console.WriteLine("pls choose only between 1 or 2");
                    continue;
                }
                break;
            }

            if (choice == 1)
            {
                return choice;
            }
            if (choice == 2)
            {
                return choice;
            }
            Console.WriteLine("Wie bin ich hier gelandet!");
            return choice;
        }
        private static short ShowMainMenu()
        {
            short userInput;
            //Console.Clear();
            Console.WriteLine("\n\n\n\t\tWelcome to Ark Lazy Tool!");
            Console.WriteLine("1. Start calculating baby max level");
            Console.WriteLine("2. Exit");
            userInput = UserInput();
            return userInput; 

            
            
        }
        public static void ShowMenu()
        {
            int choice = ShowMainMenu();
            Console.WriteLine(choice);
            switch (choice)
            {
                case 1: BabyCalculator.ReturnBabyMaxLevel();
                        Console.WriteLine("pls enter to continue");
                        Console.ReadLine();
                        ShowMainMenu();
                        break;
                case 2: Console.WriteLine("EXITING...");
                        Environment.Exit(0); 
                        break;


            }

        }
    }
}
