using System;

namespace _03.FitnessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Пол Gym Boxing Yoga Zumba Dances Pilates
            //            мъж $42 $41    $45    $34   $51    $39
            //           жена $35 $37     $42    $31  $53    $37
            //      Всички цени на карти за ученици (възраст под 19 години вкл.) са с 20% намаление.

            double startSum = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double[] maleprice = new double[] { 42, 41, 45, 34, 51, 39 };
            double[] femaleprice = new double[] { 35, 37, 42, 31, 53, 37,};
            double[] price = new double[] { 0, 0, 0, 0, 0, 0 };

            if (age <= 19)
                for (int i = 0; i < 6; i++)
                {
                    maleprice[i] *= 0.8;
                    femaleprice[i] *= 0.8;
                }
            
                for (int i = 0; i < 6; i++)
                {
                if (sex == "m")
                    price[i] = maleprice[i];
                if (sex == "f")
                    price[i] = femaleprice[i];
                }
            

            double isSumEnought = 0;

                switch (sport)
                {
                    case "Gym":
                        {
                        isSumEnought = startSum - price[0];
                            break;
                        }
                    case "Boxing":
                        {
                        isSumEnought = startSum - price[1];
                        break;
                        }

                    case "Yoga":
                    {
                        isSumEnought = startSum - price[2];
                        break;
                        }
                    case "Zumba":
                        {
                        isSumEnought = startSum - price[3];
                        break;
                        }
                    case "Dances":
                        {
                        isSumEnought = startSum - price[4];
                        break;
                        }
                    case "Pilates":
                        {
                        isSumEnought = startSum - price[5];
                        break;
                        }
                }
            
            if(isSumEnought > 0)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                   Console.WriteLine($"You don't have enough money! You need ${Math.Abs(isSumEnought):f2} more.");
            }


        }
    }
}
