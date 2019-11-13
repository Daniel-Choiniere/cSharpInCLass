using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class Die
    {
        private readonly int _numOfSides;

        private Die(int sides)
        {
            this._numOfSides = sides;
        }
        
        static private int RandomRoll()
        {
            var randomRollNumber = new Random().Next(1, 5);
            return randomRollNumber;
        }
        
        static public List<int> roll()
        {
            List<int> rolledDice = new List<int>();
            for (var i = 0; i < 5; i++)
            {
                var random = RandomRoll();
                rolledDice.Add(random);
            }
            return rolledDice;
        }
        
        static public void startGame()
        {
            Die die = new Die(6);
//            Console.WriteLine(die._numOfSides);
            var allRolls = roll();
            foreach (var item in allRolls)
            {
                Console.WriteLine(item);
            }
        }
        
        
        static void Main()
        {
            startGame();
        }
    }
}
