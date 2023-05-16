using System;
using System.Threading;

namespace P06._SumAndProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            double totalSum = a + b + c + d;
                            double totalMulti = a * b * c * d;

                            if (totalSum == totalMulti && n % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                  
                                
                                return;
                            }

                            else if (Math.Floor(totalMulti / totalSum) == 3 && n % 3 == 0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                
                                return;
                            }

                            

                        }
                    }
                }
            }
          
             Console.WriteLine("Nothing found");
            
            
                                 
                                
                                
        }
    }
}
