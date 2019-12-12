using System;
using System.Collections.Generic;

namespace BestHandCSharp
{
    public class Deck
    {
        public List<Card> Cards { get; }
        readonly Random random = new Random();
        
        private Deck()
        {
            Cards = new List<Card>();
        }
        
        public static Deck CreateFullDeck()
        {
            Deck deck = new Deck();
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int cardNumberIndex = 0; cardNumberIndex < 13; cardNumberIndex++)
                    deck.Cards.Add(new Card((Card.CardNumber)cardNumberIndex, (Suit)suitIndex));
            }
            return deck;
        }
        
        public void Shuffle()
        {
            List<Card> cardsToShuffle = new List<Card>(Cards);
            Cards.Clear();
            while (cardsToShuffle.Count > 0)
            {
                var cardIndex = random.Next(cardsToShuffle.Count);

                var cardToShuffle = cardsToShuffle[cardIndex];
                cardsToShuffle.RemoveAt(cardIndex);

                Cards.Add(cardToShuffle);
            }
        }
        
        public List<Card> CreateHand(int handSize)
        {
            List<Card> hand = new List<Card>();

            for (int numCards = 0; numCards < handSize; numCards++)
            {
                var cardIndex = random.Next(Cards.Count);

                var cardForNewHand = Cards[cardIndex];
                Cards.RemoveAt(cardIndex);
                
                hand.Add(cardForNewHand);
            }
            return hand;
        }
        
        public void DiscardCard(Card cardToDiscard)
        {
            Cards.Add(cardToDiscard);
        }
        
        public int SumOfHand(List<Card> playerHand)
        {
            var myDict = new Dictionary<string, int>
            {
                { "Two", 2 },
                { "Three", 3 },
                { "Four", 4 },
                { "Five", 5 },
                { "Six", 6 },
                { "Seven", 7 },
                { "Eight", 8 },
                { "Nine", 9 },
                { "Ten", 10 },
                { "Jack", 10 },
                { "Queen", 10 },
                { "King", 10 },
                { "Ace", 11 }
            };
            
            int total = 0;
            foreach (Card card in playerHand)
            {
                int result;
                if (myDict.TryGetValue(card.Number.ToString(), out result))
                    total += result;
            }   
            Console.Write("Total sum of hand is: " + total + "\n");
            return total;
        }
   
    }    
}