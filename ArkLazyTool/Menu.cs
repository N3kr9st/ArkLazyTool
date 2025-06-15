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
        private static short ShowMainMenu()
        {
            //Console.Clear();
            Console.WriteLine("Welcome to Ark Lazy Tool!");
            Console.WriteLine("1. Start calculating baby max level");
            Console.WriteLine("2. Exit");
            Console.Write("Please select an option: ");

            short choice = short.Parse(Console.ReadLine() ?? "0");

            if (choice == 1)
            {
                return choice;
            }else if (choice == 2)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("INVALID INPUT!");
                ShowMainMenu();
            }

            Console.WriteLine("WARUM BIN ICH HIER ?");
            return choice;


                

        }
        public static void ShowMenu()
        {
            int choice = ShowMainMenu();
            Console.WriteLine(choice);
            switch (choice)
            {
                case 1: BabyCalculator.ReturnBabyMaxLevel();
                        Console.ReadLine(); 
                        break;
                case 2: Console.WriteLine("EXITING...");
                        Environment.Exit(0); 
                        break;


            }

        }
    }
}
