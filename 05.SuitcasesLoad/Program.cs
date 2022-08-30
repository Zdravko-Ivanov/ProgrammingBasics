using System;

namespace _05.SuitcasesLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double spaceCapacity = double.Parse(Console.ReadLine());
            string obem = Console.ReadLine();
            int count = 1;

            while (obem != "End")
            {
                double temp = double.Parse(obem);

                if (count % 3 == 0 && count != 0)
                {
                    temp = double.Parse(obem) * 1.1;
                }

                spaceCapacity -= temp;

                if (spaceCapacity == 0)
                {
                    count++;
                    break;
                }

                if (spaceCapacity < 0)
                {
                    break;
                }
                count++;
                obem = Console.ReadLine();
            }


            if (spaceCapacity >= 0)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else if (spaceCapacity < 0)
            {
                Console.WriteLine("No more space!");
            }

            Console.WriteLine($"Statistic: {count-1} suitcases loaded.");

        }
    }
}
