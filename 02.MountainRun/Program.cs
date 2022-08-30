using System;

namespace _02.MountainRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double timeGeorge = (meters * time) + (Math.Floor(meters / 50) * 30);

            if (record > timeGeorge)
            {
                Console.WriteLine($"Yes! The new record is {timeGeorge:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(timeGeorge - record):f2} seconds slower.");
            }
        }
    }
}
