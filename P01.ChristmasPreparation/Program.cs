using System;

namespace P01.ChristmasPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packingPaper = int.Parse(Console.ReadLine());
            int fabricRolls = int.Parse(Console.ReadLine()) ;
            double glue = double.Parse(Console.ReadLine()) ;
            double discount = double.Parse(Console.ReadLine())/100 ;

            double packingPaperPrice = 5.80;
            double fabricRollsPrice = 7.20;
            double gluePrice = 1.20;

            double totalPrice = (packingPaper * packingPaperPrice) + (fabricRolls * fabricRollsPrice) + (glue * gluePrice);
            totalPrice -= totalPrice * discount;
            Console.WriteLine($"{totalPrice:F3}");
        }
    }
}
