using System;
using System.Collections.Generic;

namespace DnD
{
    public class Die
    {
        public int rollNum;
        public Die(int sides)
        {
            rollNum  = new Random().Next(1, sides);
        }
    }
    
    class Program
    {
        static void Main()
        {
            StartGame();
        }
        
        private static void StartGame()
        {
            Die die1 = new Die(20);
            Console.WriteLine("Intial Roll: " + die1.rollNum);

            int modifier = 10;
            int armorClass = 20;
            int numDamageDice = 2;

            if (die1.rollNum == 1)
            {
                Console.WriteLine("Critical Miss!!!");
                return;
            }
            
            int damageDealt = die1.rollNum + modifier;
            
            if (damageDealt < armorClass && die1.rollNum < 20)
            {
                Console.WriteLine("Critical Miss!!!");
            }
            else
            {
                List<int> damageDiceArr = new List<int>();
                
                for (var i = 0; i < numDamageDice; i++)
                {
                    Die damageDie = new Die(8);
                    damageDiceArr.Add(damageDie.rollNum);
                }
                
                int totalHitPoints = 0;
                foreach (var dieValue in damageDiceArr)
                {
                    totalHitPoints += dieValue;
                }
            
                Console.WriteLine("Hit! " + totalHitPoints + " Hit Points Dealt!!");
            }
        }
    }
}

//Time for MVP 1:41

