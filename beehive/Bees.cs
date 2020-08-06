namespace beehive
{
    public class Bees
    {
        public string Name;
        public float Size;

        public Bees()
        {
            this.Name= "";
            this.Size = 0;
        }
        public Bees(string name, float size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}