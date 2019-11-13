using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class Die
    {
        private readonly int _numOfSides;

        private Die(int sides)
        {
            _numOfSides = sides;
        }
        
        private static int RandomRoll(int numOfRolls)
        {
            var randomRollNumber = new Random().Next(1, numOfRolls);
            return randomRollNumber;
        }
        
        private static IEnumerable<int>Roll(int numRolls)
        {
            List<int> rolledDice = new List<int>();

            var numOfRolls = 5;
            for (var i = 0; i < numRolls; i++)
            {
                var random = RandomRoll(numOfRolls);
                rolledDice.Add(random);
            }
            return rolledDice;
        }
        
        private static void StartGame()
        {
            Die die = new Die(6);
//            Console.WriteLine(die._numOfSides);
            var numOfRolls = 5;
            var allRolls = Roll(numOfRolls);
            foreach (var item in allRolls)
            {
                Console.WriteLine(item);
            }
        }
        
        private static void Main()
        {
            StartGame();
        }
    }
}
