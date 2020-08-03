namespace beehive
{
    public class BeeHiveList
    {
        public List<Bee> beesList1;
        public List<Bee> beesList2;
        public BeeHiveList()
        {
            this.beesList1 = new List<Bee>();
            this.beesList2 = new List<Bee>();
        }
        public void AddBees(Car newBee)
        {
            this.beesList.Add(newBee);
        }
    }
}