using System;
using System.Collections.Generic;

namespace BestHandCSharp
{
    public class Deck
    {
        private static Random random = new Random();
        
        /// Contains 52 cards (4 suits with 13 cards each)
        public List<Card> Cards { get; }
        
        private Deck()
        {
            // This is private so that Deck.CreateFullDeck() is used to create a deck
            Cards = new List<Card>();
        }

       
        /// Creates the deck of cards, from Ace to King by suit.
        /// <returns>The initialized deck of cards</returns>
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

        public void SortAscending()
        {
            Cards.Sort();
        }
        
        /// Shuffle the deck by first making a copy of it and clearing the original deck.  Then,
        /// we'll randomly grab cards from our copy of the deck and add them to the original.
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
    }
}