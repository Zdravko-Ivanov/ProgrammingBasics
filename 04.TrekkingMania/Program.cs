using System;

namespace _04.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
//             Група до 5 човека– Мусала
// Група от 6 до 12 – Монблан
// Група от 13 до 25 – Килиманджаро
// Група от 26 до 40 – К2
// Група от 41 или повече – Еверест
            int numOfGroups = int.Parse(Console.ReadLine());
            double[] group = new double[5];
            double total = 0;


            for (int i = 0; i < numOfGroups; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                    if (temp <= 5 && temp > 0) group[0] += temp; 
                    if (temp <= 12 && temp > 5) group[1] += temp; 
                    if (temp <= 25 && temp > 12) group[2] += temp; 
                    if (temp <= 40 && temp > 25) group[3] += temp; 
                    if (temp >= 41) group[4] += temp;

                total += temp;
             }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{group[i] / total * 100:f2}%");
            }
        }
    }
}
