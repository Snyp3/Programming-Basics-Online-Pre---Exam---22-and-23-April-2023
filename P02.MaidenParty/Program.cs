using System;

namespace P02.MaidenParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int favoriteMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keyholders = int.Parse(Console.ReadLine());
            int caricature = int.Parse(Console.ReadLine());
            int mysterySurprise = int.Parse(Console.ReadLine());

            double favoriteMessagesPrice = 0.60;
            double waxRosesPrice = 7.20;
            double keyholdersPrice = 3.60;
            double caricaturePrice = 18.20;
            double mysterySurprisePrice = 22;

            int totalArtSells = favoriteMessages + waxRoses + keyholders + caricature + mysterySurprise;
            double totalSumEarned = favoriteMessages * favoriteMessagesPrice 
                                    + waxRoses * waxRosesPrice 
                                        + keyholders * keyholdersPrice
                                            +caricature * caricaturePrice
                                                + mysterySurprise * mysterySurprisePrice;

            if (totalArtSells >= 25)
            {
                totalSumEarned -= totalSumEarned * 0.35;
            }
            totalSumEarned -= totalSumEarned * 0.10;

            if (totalSumEarned >= partyPrice)
            {
                Console.WriteLine($"Yes! {totalSumEarned - partyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice - totalSumEarned:f2} lv needed.");
            }
        }
    }
}
