using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArkLazyTool
{
    internal class Menu
    {
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Ark Lazy Tool!");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Settings");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");
            
            int choice = int.Parse(Console.ReadLine());
        }
        
    }
}
