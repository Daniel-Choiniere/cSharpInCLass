using System;

namespace GoFish
{
    public static class FishForCard
    {
        public static void Fish(Deck playerOne, Deck AI)
        {
            foreach (var item in playerOne.Cards)
            {
                Console.WriteLine("Deck One: {0} {1}",  item.Number, item.Suit);
            }
            Console.WriteLine("\n");
            
            foreach (var item in AI.Cards)
            {
                Console.WriteLine("Deck Two: {0} {1}",  item.Number, item.Suit);
            }
            
            Console.Write("What card would you like to try for a match: ");
            var fishCard = Console.ReadLine();
//            Console.WriteLine(fishCard);
            foreach (var item in AI.Cards)
            {
                string cardDescrip = item.Number + " " +  item.Suit;
                if (cardDescrip == fishCard)
                {
                    Console.WriteLine("Holla At cha Boy!!!");
                }
            }
        }
    }
}