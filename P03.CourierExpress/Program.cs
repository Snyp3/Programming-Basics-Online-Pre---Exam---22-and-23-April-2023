using System;

namespace P03.CourierExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packegeKg = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int distanceKm = int.Parse(Console.ReadLine());

            double pricePerKm = 0;


            if (serviceType == "standard")
            {


                if (packegeKg <= 1)
                {
                    pricePerKm = distanceKm * 0.03;
                }
                else if (packegeKg <=10)
                {
                    pricePerKm = distanceKm * 0.05;
                }
                else if (packegeKg <= 40)
                {
                    pricePerKm = distanceKm * 0.10;
                }
                else if (packegeKg <= 90)
                {
                    pricePerKm = distanceKm * 0.15;
                }
                else if (packegeKg <= 150)
                {
                    pricePerKm = distanceKm * 0.20;
                }
            }



            else if (serviceType == "express")
            {
                if (packegeKg <= 1)
                {
                    pricePerKm = distanceKm * 0.03 + packegeKg * distanceKm * 0.03 * 0.80;
                }
                else if (packegeKg <= 10)
                {
                    pricePerKm = distanceKm * 0.05 + packegeKg * distanceKm * 0.05 * 0.40;
                }
                else if (packegeKg <= 40)
                {
                    pricePerKm = distanceKm * 0.10 + packegeKg * distanceKm * 0.10 * 0.05;
                }
                else if (packegeKg <= 90)
                {
                    pricePerKm = distanceKm * 0.15 + packegeKg * distanceKm * 0.15 * 0.02;
                }
                else if (packegeKg <= 150)
                {
                    pricePerKm = distanceKm * 0.20 + packegeKg * distanceKm * 0.20 * 0.01;
                }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {packegeKg:f3} kg. would cost {pricePerKm:f2} lv.");
        }
    }
}
