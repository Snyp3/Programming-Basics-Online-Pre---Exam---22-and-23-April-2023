using System;

namespace P05.HairSalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetForDay = int.Parse(Console.ReadLine());
            int moneyEarnd = 0;
            int priceForWork = 0;
            string work;
            string workType;
           

            while ((work = Console.ReadLine()) != "closed")
            {
                if (work == "haircut")
                {
                    workType = Console.ReadLine();

                    if (workType== "mens")
                    {
                        priceForWork = 15;
                    }
                    else if (workType== "ladies")
                    {
                        priceForWork = 20;
                    }
                    else if (workType == "kids")
                    {
                        priceForWork = 10;
                    }
                }
                else if (work == "color")
                {
                    workType= Console.ReadLine();

                    if (workType== "touch up")
                    {
                        priceForWork = 20;
                    }
                    else if (workType == "full color")
                    {
                        priceForWork = 30;
                    }
                }

                moneyEarnd += priceForWork;

                if (moneyEarnd >= targetForDay)
                    {
                    Console.WriteLine("You have reached your target for the day!");
                    break;
                    
                    }
            } 
            if (moneyEarnd < targetForDay)
                {
                    Console.WriteLine($"Target not reached! You need {targetForDay - moneyEarnd}lv. more.");
                }

            Console.WriteLine($"Earned money: {moneyEarnd}lv.");  
        }
    }
}
