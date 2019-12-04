namespace GoFish
{
    namespace CardDeck
    {
        public class Card
        {
            public enum CardNumber
            {
                Ace,
                Two,
                Three,
                Four,
                Five,
                Six,
                Seven,
                Eight,
                Nine,
                Ten,
                Jack,
                Queen,
                King
            }

            public CardNumber Number { get; }
            public Suit Suit { get; }

            public Card(CardNumber number, Suit suit)
            {
                Number = number;
                Suit = suit;
            }
        }
    }
}