using System;

namespace P04.Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double kmRunned = + M;
            double kmOverAll = kmRunned;

            for (int i = 1; i <= N; i++)
            {
                int bonusProcent = int.Parse(Console.ReadLine());
                kmRunned += kmRunned * bonusProcent / 100;
                kmOverAll += kmRunned;
            }

            if (kmOverAll >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(kmOverAll - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - kmOverAll)} more kilometers");
            }
        }
    }
}
