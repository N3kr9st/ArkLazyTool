using System.ComponentModel.Design;

namespace ArkLazyTool
{
    internal class BabyCalculator
    {
        static int dinoCount = HowManyBabys();
        static Dino[] dinos = new Dino[dinoCount];
        private const int BABY_START_LEVEL = 1;
        static int babyMaxLevel = 0;
        
        public static int HowManyBabys()
        {
            Console.WriteLine("How many Dinos are used?");
            int dinoCount = int.Parse(Console.ReadLine() ?? "0");
            if (dinoCount < 1 || dinoCount > 7)
            {
                Console.WriteLine("Not a valid input!");
                return 0;
            }
            else
            {
                Console.WriteLine(dinoCount);
                return dinoCount;
            }
        }


    }
}
