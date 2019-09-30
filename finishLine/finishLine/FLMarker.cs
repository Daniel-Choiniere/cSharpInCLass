namespace finishLine
{
    public class FLMarker : Marker
    {
        public bool stopped;

        public FLMarker(string name) : base(name)
        {
            stopped = false;
        }

        public void Move(int spaces, int stopValue, Deck gameDeck)
        {
            for (int count = 1; count <= spaces; count++)
            {
                if (position + count >= gameDeck.cards.Count)
                    return;
                if (gameDeck.cards[position + count].val >= stopValue)
                {
                    Move(count);
                    return;
                }
            }
            // preprocessing
            Move(spaces);
            // postprocess
        }
    }
}
