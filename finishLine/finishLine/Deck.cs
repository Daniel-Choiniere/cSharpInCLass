using System;
using System.Collections.Generic;

namespace finishLine
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck(int[] values, int[] suits, int numJokers)
        {
            foreach (var suit in suits)
            {
                foreach (var val in values)
                {
                    cards.Add(new Card(val, suit));
                }
            }
            for (int jkr = 0; jkr < numJokers; jkr++)
            {
                cards.Add(new Card(0, 0));
            }
        }

        public void Shuffle(Random rand)
        {
            for (int index = cards.Count - 1; index > 0; index--)
            {
                int position = rand.Next(index + 1);
                Card temp = cards[index];
                cards[index] = cards[position];
                cards[position] = temp;
            }
        }
    }
}
