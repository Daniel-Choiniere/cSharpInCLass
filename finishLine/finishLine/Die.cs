using System;

namespace finishLine
{
        public class Die
    {
        // sides value color
        public int val;
        private int sides;
        public int color;

        public Die(int sides, int color)
        {
            this.sides = sides;
            this.color = color;
            val = 1;
        }

        public Die(int sides)
        {
            this.sides = sides;
            val = 1;
        }

        public Die()
        {
            sides = 6;
            val = 1;
        }

        public void Roll(Random rand)
        {
            val = rand.Next(1, sides + 1);
        }
    }
}
