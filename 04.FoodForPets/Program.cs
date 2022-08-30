using System;

namespace _04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double quantity = double.Parse(Console.ReadLine());
            double eatenByDog = 0;
            double eatenByCat = 0;
            double cookies = 0;

            for (int i = 1; i <= days; i++)
            { 
                double temp1 = double.Parse(Console.ReadLine());
                double temp2 = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                    cookies += temp1 + temp2;
                eatenByCat += temp2;
                eatenByDog += temp1;
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Floor(cookies*0.1)}gr.");
            Console.WriteLine($"{(eatenByDog + eatenByCat) / quantity * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatenByDog / (eatenByDog + eatenByCat) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{eatenByCat / (eatenByDog + eatenByCat) * 100:f2}% eaten from the cat.");

        }
    }
}
