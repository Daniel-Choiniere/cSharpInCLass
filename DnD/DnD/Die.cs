using System;

namespace DnD
{
    public class Die
    {
        private int rollNum;
        public Die(int sides)
        {
            rollNum  = new Random().Next(1, sides);
        }
        
        public int GetRollnum() 
        { 
            return rollNum; 
        }
    }
}