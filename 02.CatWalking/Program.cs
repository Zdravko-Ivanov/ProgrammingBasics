using System;

namespace _02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minWalk = int.Parse(Console.ReadLine());
            int numWalk = int.Parse(Console.ReadLine());
            double cal = int.Parse(Console.ReadLine());

            double consumedCal = minWalk * 5 * numWalk;

            if (consumedCal >= cal / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {consumedCal}.");
            }

            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {consumedCal}.");
            }
        

        }
    }
}
