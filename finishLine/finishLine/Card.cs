using System.Collections.Generic;

namespace finishLine
{
    public class Card
    {
        public int suit;
        public int val;
        private Dictionary<int, string> SUIT_MAP = new Dictionary<int, string> {
    {0, "\u2663"},
    {1, "\u2660"},
    {2, "\u2665"},
    {3, "\u2666"}
  };
        private Dictionary<int, string> VAL_MAP = new Dictionary<int, string> {
    {1, "Ac"},
    {10, "10"},
    {11, "Ja"},
    {12, "Qu"},
    {13, "Ki"}
  };

        public Card(int val, int suit)
        {
            this.val = val;
            this.suit = suit;
        }

        public string Display()
        {
            if (val == 0)
            {
                return "Jkr";
            }

            if (VAL_MAP.ContainsKey(this.val))
            {
                return SUIT_MAP[suit] + VAL_MAP[val];
            }

            return SUIT_MAP[suit] + "0" + val;

        }

    }
}
