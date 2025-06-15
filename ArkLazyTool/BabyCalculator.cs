
namespace ArkLazyTool
{
    internal class BabyCalculator
    {      
        static String[] statNames = Dino.statNames;        
        static int[] maxLevels = new int[statNames.Length];
        const int BABY_START_LEVEL = 1;
        static int babyMaxLevel = 0;

        
        
        static int HowManyDinos()
        { 
            Console.WriteLine("How many Dinos are used?");
            int dinoCount = int.Parse(Console.ReadLine() ?? "0");
            if (dinoCount is < 2 or > 8)
            {
                Console.WriteLine("Not a valid input! Try again!");
                HowManyDinos();
            }

            return dinoCount ;
        }

        static int GetDinoValue(String valueName)
        {
            int value;
            string userInput;

            while (true)
            {
                Console.WriteLine($"Pls give the Value of {valueName} ");
                userInput = Console.ReadLine() ?? "0";
                if (!int.TryParse(userInput, out value))
                {
                    Console.WriteLine("Input is not an integer! Please try again.");
                    continue;
                }
                if (value == 0)
                {
                    Console.WriteLine("Wrong input pls try again!");
                    continue;
                }
                break;
            }
            return value;
        }

        static Dino[] CreateDinoArray(int dinoCount)
        {
            Dino[] dinos = new Dino[dinoCount];
            int[] levels = new int[statNames.Length];
            for (int i = 0; i < dinoCount; i++)
            {
                Console.WriteLine($"Dino Nr: {i + 1}");
                for (int j = 0; j < levels.Length; j++)
                {
                    int value = GetDinoValue(statNames[j]);

                    levels[j] = value;
                }
                dinos[i] = new Dino(levels);

            }
            return dinos;

        }

        static int CalcMaxBabyLevel(Dino[] dinos)
        {

            for (int i = 0; i < dinos.Length; i++)
            {
                Dino dino = dinos[i];
                

                for (int j = 0; j < statNames.Length; j++)
                {
                    int statValue = 0;
                    switch (statNames[j].ToLower())
                    {
                        case "hp":
                            statValue = dino.GetHp();
                            break;
                        case "damage":
                            statValue = dino.GetDamage();
                            break;
                        case "speed":
                            statValue = dino.GetSpeed();
                            break;
                        case "food":
                            statValue = dino.GetFood();
                            break;
                        case "ox":
                            statValue = dino.GetOx();
                            break;
                        case "weight":
                            statValue = dino.GetWeight();
                            break;
                        case "stamina":
                            statValue = dino.GetStamina();
                            break;
                        case "torpor":
                            statValue = dino.GetTorpor();
                            break;
                    }
                    if (statValue > maxLevels[j])
                    {
                        maxLevels[j] = statValue;
                    }
                    
                }
            }
            Console.Clear();
            for(int i = 0; i < maxLevels.Length; i++)
            {

                Console.WriteLine($"Max Value of {statNames[i]} is: {maxLevels[i]}");
                babyMaxLevel += maxLevels[i];
            }

            return BABY_START_LEVEL + babyMaxLevel;

        }

        public static void ReturnBabyMaxLevel()
        {
            int dinoCount = HowManyDinos();
            Dino[] dinos = CreateDinoArray(dinoCount);
            int level = CalcMaxBabyLevel(dinos);
            Console.WriteLine($"\nBaby Max Level is: {level}");
        }

    }
}
