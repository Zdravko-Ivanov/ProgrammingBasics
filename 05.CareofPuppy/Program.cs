using System;

namespace _05.CareofPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buyFood = int.Parse(Console.ReadLine());
            string grams = Console.ReadLine();
            double totalFoodConsumed = 0;

            while (grams != "Adopted")
            {
                int temp = int.Parse(grams);

                totalFoodConsumed += temp;

                grams = Console.ReadLine();
            }

            if (totalFoodConsumed <= buyFood * 1000)
            {
                Console.WriteLine($"Food is enough! Leftovers: {buyFood * 1000 - totalFoodConsumed} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodConsumed - buyFood*1000} grams more.");
            }

        }
    }
}
