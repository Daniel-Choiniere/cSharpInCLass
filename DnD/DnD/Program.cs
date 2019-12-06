using System;
using System.Collections.Generic;

namespace DnD
{
    class Program
    {
        static void Main()
        {
            StartGame();
        }
        
        private static void StartGame()
        {
            int modifier = 10;
            int armorClass = 20;

            Die die1 = new Die(20);

            int rollNumber = die1.GetRollnum();
            Console.WriteLine("Initial Roll: " + rollNumber);
            
            if (rollNumber == 1)
            {
                Console.WriteLine("Critical Miss!!!");
                return;
            }
            
            int damageDealt = rollNumber + modifier;
            Console.WriteLine("The initial roll number is " + rollNumber +  " and the modifier is " + modifier + ". Your total damage dealt is " + (modifier + rollNumber) );
            Console.WriteLine("Your Armor Class is " + armorClass);
            
            if (damageDealt <= armorClass && rollNumber < 20)
            {
                Console.WriteLine("Critical Miss!!!");
                return;
            }
            
            if (rollNumber == 20)
            {
                Console.WriteLine("Critical Hit!!!");
                HitPoints(2);
            }
            else
            {
                HitPoints(1); 
            }
        }

        private static void HitPoints(int numDice)
        {
            if (numDice == 1)
            {
                Console.WriteLine("Your armor was no match for that attack!");
            }
            List<int> damageDiceArr = new List<int>();
            
            for (var i = 0; i < numDice; i++)
            {
                Die damageDie = new Die(8);
                damageDiceArr.Add(damageDie.GetRollnum());
            }
            
            int totalHitPoints = 0;
            foreach (var dieValue in damageDiceArr)
            {
                Console.WriteLine("Damage Roll: " + dieValue);
                totalHitPoints += dieValue;
            }
        
            Console.WriteLine("Hit! " + totalHitPoints + " Hit Points Dealt!!");
        }
    }
}


