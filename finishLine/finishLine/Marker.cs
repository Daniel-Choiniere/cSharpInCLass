namespace finishLine
{
    public class Marker
    {
        public int position;
        public string name;


        public Marker(string name)
        {
            position = -1;
            this.name = name;
        }

        public virtual void Move(int spaces)
        {
            position += spaces;
        }
    }
}
