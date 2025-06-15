using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ArkLazyTool
{
    internal class BabyCalculator
    {
        static int dinoCount = HowManyDinos();
        static Dino[] dinos = new Dino[dinoCount];        
        static String[] statNames = {"hp","damage","speed","food","ox","weight","stamina","topor"};        
        static int[] maxLevels = new int[statNames.Length];
        const int BABY_START_LEVEL = 1;
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
                int[] levels = new int[statNames.Length];
                for (int j = 0; j < statNames.Length; j++) {
                    
                    Console.WriteLine($"Pls give the Value of {statNames[j]}");
                    levels[j] = int.Parse(Console.ReadLine() ?? "0");

                }
                dinos[i] = new Dino(levels);
            }

        }

        static int CalcMaxBabyLevel()
        {
            for (int i = 0; i < dinos.Length; i++)
            {
                Dino dino = dinos[i];
                for (int j = 0; j < statNames.Length; j++)
                {
                    string statName = statNames[j];
                    
                    // Holt per Reflection die PropertyInfo für das aktuelle Stat (z.B. "hp") aus der Dino-Klasse.
                    // Anschließend wird der Wert dieser Eigenschaft für das aktuelle Dino-Objekt ausgelesen
                    // und in einen int umgewandelt.
                    PropertyInfo property = dino.GetType().GetProperty(statName);
                    int value = (int)property.GetValue(dino);
                    
                    if (maxLevels[j] < value)
                    {
                        maxLevels[j] = value;
                    }

                }
            }
            foreach(int i in maxLevels)
            {
                babyMaxLevel += maxLevels[i];
            }
            return babyMaxLevel;


        }

    }
}
