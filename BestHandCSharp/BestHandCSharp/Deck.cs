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
                {
                    deck.Cards.Add(new Card((Card.CardNumber)cardNumberIndex, (Suit)suitIndex));
                }
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
        
        public void CreateHand()
        {
            int handSize = 8;
            
            List<Card> cardsToMakeHandFrom = new List<Card>(Cards);
            Cards.Clear();
            
            for (int numCards = 0; numCards < handSize; numCards++)
            {
                var cardIndex = random.Next(cardsToMakeHandFrom.Count);

                var cardForNewHand = cardsToMakeHandFrom[cardIndex];
                cardsToMakeHandFrom.RemoveAt(cardIndex);

                Cards.Add(cardForNewHand);
            }
        }

        public void SumOfHand()
        {
            foreach (Card card in Cards)
            {
//                Console.WriteLine(card.Number);
                if (card.Number.ToString() == "Jack")
                {
                    Console.WriteLine("Hola");
                }
            }    
        }
    }
}