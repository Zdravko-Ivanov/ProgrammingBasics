using System;
using System.Dynamic;
using System.Net.Http.Headers;

namespace _01._ChangeBureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1 биткойн = 1168 лева.
            //            1 китайски юан = 0.15 долара.
            //            1 долар = 1.76 лева.
            //            1 евро = 1.95 лева.
            // комисионна от 0 до 5 процента от крайната сума в евро

            int numberBitcoin = int.Parse(Console.ReadLine());
            double numberIena = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitcoinInLeva = numberBitcoin * 1168;
            double ienaInLeva = numberIena * 0.15 * 1.76;
            double com = commision / 100;


            double sumInEuro = (bitcoinInLeva + ienaInLeva) / 1.95;

            double finalResult = sumInEuro * (1 - com);
            Console.WriteLine($"{finalResult:f2}");



        }
    }
}
