using System;

namespace DnD
{
    public class Die
    {
        public int sides;
        public int rollNum;
        public Die(int sides)
        {
            rollNum  = new Random().Next(1, sides);
        }
    }

    class Program
    {
        private static void StartGame()
        {
            Die die1 = new Die(20);
            Console.WriteLine("Intial Roll: " + die1.rollNum);

            int modifier = 10;
            int armorClass = 20;

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
                Die damageDie1 = new Die(8);
                Die damageDie2 = new Die(8);

                int totalHitPoints = damageDie1.rollNum + damageDie2.rollNum;
            
                Console.WriteLine("Hit! " + totalHitPoints + " Hit Points Dealt!!");
            }
            
        }
        
        static void Main()
        {
//            Console.WriteLine(die1.rollNum);
            StartGame();
        }
    }
}


