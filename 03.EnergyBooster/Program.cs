using System;
using System.Security.Cryptography.X509Certificates;

namespace _03.EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //               Диня       Манго           Ананас          Малина
            //2 броя(small) 56 лв./ бр. 36.66 лв./ бр. 42.10 лв./ бр. 20 лв./ бр.
            //5 броя(big) 28.70 лв./ бр. 19.60 лв./ бр. 24.80 лв./ бр. 15.20 лв./ бр.

//              от 400 лв.до 1000 лв.включително има 15 % отстъпка
//               над 1000 лв.има 50 % отстъпка


            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            
            double price = 0;

            switch(fruit)
            {
                case "Watermelon":
                    {
                        if (size == "big")
                            price = 5 * 28.70 * count;
                        else
                            price = 2 * 56 * count;
                    }                    
                    break;
                case "Mango":
                    if (size == "big")
                        price = 5 * 19.60 * count;
                    else
                        price = 2 * 36.66 * count;
                    break;
                case "Pineapple":
                    if (size == "big")
                        price = 5 * 24.80 * count;
                    else
                        price = 2 * 42.10 * count;
                    break;
                case "Raspberry":
                    if (size == "big")
                        price = 5 * 15.20 * count;
                    else
                        price = 2 * 20 * count;
                    break;
            }

            if(price >= 400 && price <= 1000)
                Console.WriteLine($"{(price*0.85):f2} lv.");
            else if(price > 1000)
                Console.WriteLine($"{(price/2):f2} lv.");
            else
                Console.WriteLine($"{price:f2} lv.");


        }
    }
}
