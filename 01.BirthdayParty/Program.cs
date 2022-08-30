using System;

namespace _01.BirthdayParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceRent = int.Parse(Console.ReadLine());
            double priceCake = priceRent * 0.2;
            double priceDrinks = priceCake * 0.55;
            double priceAnimator = priceRent / 3;

            Console.WriteLine(priceRent + priceCake + priceDrinks + priceAnimator);
        }
    }
}
