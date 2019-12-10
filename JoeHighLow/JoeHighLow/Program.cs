using System;

namespace HighLow
{
    class Program
    {
        static Random rand = new Random();
        private static void Main()
        {
            Game game = new Game();
        }
        
        private class Card
        {
            private int _suit;
            private int _value;

            public Card()
            {
                this._suit = rand.Next(1, 4);
                this._value = rand.Next(1, 13);
            }

            public int Value
            {
                get
                {
                    return this._value;
                }
                set
                {
                    this._value = value;
                }
            }

            public int Suit
            {
                get
                {
                    return this._suit;
                }
                set
                {
                    this._suit = value;
                }
            }

            public string TextSuit(int suit)
            {
                switch (suit)
                {
                    case 1:
                        return " of Clubs";
                    case 2:
                        return " of Hearts";
                    case 3:
                        return " of Diamonds";
                    case 4:
                        return " of Spades";
                }
                return "NaN";
            }
            
            public string TextValue(int value)
            {
                switch (value)
                {
                    case 1:
                        return "Ace";
                    case 2:
                        return "Two";
                    case 3:
                        return "Three";
                    case 4:
                        return "Four";
                    case 5:
                        return "Five";
                    case 6:
                        return "Six";
                    case 7:
                        return "Seven";
                    case 8:
                        return "Eight";
                    case 9:
                        return "Nine";
                    case 10:
                        return "Ten";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                }
                return "NaN";
            }
        }
        
        private class Game
        {
            bool quit = false;
            private Card _currentCard;
            public Game()
            {
                _currentCard = new Card();
                Score = 0;

                DisplayCurrent(_currentCard);

                while (!quit)
                {
                    Console.WriteLine(CheckValue(_currentCard.Value, PlayerGuess()));

                    if (quit == true)
                    {
                        Console.WriteLine("Exiting...");
                        return;
                    }
                    else
                    {
                        _currentCard = new Card();
                        DisplayCurrent(_currentCard);
                    }
                }

                Console.WriteLine("Final Score: {0}", Score);
            }

            private string PlayerGuess()
            {
                Console.WriteLine("Will the next card be higher or lower? ('high', 'low', or 'quit')");
                string guess = Console.ReadLine();
                return guess;
            }

            private string CheckValue(int cardValue, string guess)
            {
                Card card = new Card();

                if (card.Value == cardValue)
                {
                    return "Draw! No points!";
                }
                switch (guess)
                    {
                        case "high":
                            if (card.Value > cardValue)
                            {
                                Score = Score + 1;
                                return "Correct!";
                            }
                            return "Incorrect!";
                        case "low":
                            if (card.Value < cardValue)
                            {
                                Score = Score + 1;
                                return "Correct!";
                            }
                            return "Incorrect!";
                        case "quit":
                            quit = true;
                            return "Score: " + Score.ToString();
                    }
                    return "Incorrect input";
                
            }

            private void DisplayCurrent(Card card)
            {
                Console.WriteLine("{0}{1}", card.TextValue(card.Value), card.TextSuit(card.Suit));
            }

            private int Score { get; set; }
        }
    }
}