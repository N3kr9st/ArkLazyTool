using System.ComponentModel.Design;

namespace ArkLazyTool
{
    internal class BabyCalculator
    {
        static int dinoCount = HowManyDinos();
        static Dino[] dinos = new Dino[dinoCount];
        static int[] maxLevels = new int[8];
        static String[] statNames = {"hp","damage","speed","food","ox","weight","stamina","topor"};            
        private const int BABY_START_LEVEL = 1;
        static int babyMaxLevel = 0;

        
        
        static int HowManyDinos()
        {
     
            Console.WriteLine("How many Dinos are used?");
            int dinoCount = int.Parse(Console.ReadLine() ?? "0");
            if (dinoCount is <= 2 or >= 8)
            {
                Console.WriteLine("Not a valid input! Try again!");
                HowManyDinos();
            }
            else
            {
                Console.WriteLine(dinoCount);
                return dinoCount;
            }
            return dinoCount;
        }

        static void CreateDinoArray()
        {
            for (int i = 0; i < dinoCount; i++)
            {
                for (int j = 0; j < maxLevels.Length; j++) {
                    Console.WriteLine($"Pls give the Value of {statNames[j]}");
                    maxLevels[j] = int.Parse(Console.ReadLine() ?? "0");
                }
                dinos[i] = new Dino(maxLevels[0], maxLevels[1], maxLevels[2], maxLevels[3], maxLevels[4], maxLevels[5], maxLevels[6], maxLevels[7]);

            }

        }




    }
}
