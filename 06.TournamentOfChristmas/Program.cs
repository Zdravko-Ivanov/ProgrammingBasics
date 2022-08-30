using System;
using System.Security.Cryptography.X509Certificates;

namespace _06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string stats;
            double winCount = 0, looseCount = 0, money = 0;

            for (int i = 0; i < days; i++)
            {
                double tempWinCount = 0, tempLooseCount = 0, tempMoney = 0; 

                string sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    stats = Console.ReadLine();
                    if (stats == "win")
                    {
                        tempMoney += 20;
                        winCount++;
                        tempWinCount++;
                    }
                    else
                    {
                        looseCount++;
                        tempLooseCount++;
                    }
                    sport = Console.ReadLine();
                }
                if (tempWinCount > tempLooseCount)
                {
                    tempMoney *= 1.1;
                }
                money += tempMoney;
            }

            if (winCount > looseCount)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {money*1.2:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }    
        }
    }
}
