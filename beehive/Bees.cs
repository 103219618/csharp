namespace beehive
{
    public class Bees
    {
        public string Name;
        public int Size; //use float for decimal

        public Bees()
        {
            this.Name= "";
            this.Size = 0;
        }
        public Bees(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}