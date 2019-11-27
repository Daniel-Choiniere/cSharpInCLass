using System;
using System.Collections.Generic;

namespace BestHandCSharp
{
    public class Deck
    {
        /// Contains 52 cards (4 suits with 13 cards each)
        public List<Card> Cards { get; }
        
        private Deck()
        {
            // This is private so that Deck.CreateFullDeck() is used to create a deck
            Cards = new List<Card>();
        }

       
        /// Creates the deck of cards from Ace to King by suit.
        /// Returns The initialized deck of cards
        public static Deck CreateFullDeck()
        {
//            create a new deck object which gives us the Cards list
            Deck deck = new Deck();
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int cardNumberIndex = 0; cardNumberIndex < 13; cardNumberIndex++)
                {
//                    on each iteration create a new Card object and add it to the Cards List
                    deck.Cards.Add(new Card((Card.CardNumber)cardNumberIndex, (Suit)suitIndex));
                }
            }
            return deck;
        }

        /// Shuffle the deck by first making a copy of it and clearing the original deck.  Then,
        /// we'll randomly grab cards from our copy of the deck and add them to the original.
        public void Shuffle()
        {
            Random random = new Random();
            
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