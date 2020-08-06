using System.Collections.Generic;

namespace beehive
{
    public class BeeHiveList
    {
        public List<Bees> bees;
        public int maxBees = 4;
        public BeeHiveList()
        {
            this.bees = new List<Bees>();
            this.maxBees = 4;
        }
        public void AddBees(Bees newBee)
        {
            if (bees.Count > this.maxBees)
            {
                System.Console.WriteLine("maximum bees in the hive");
            } else
            this.bees.Add(newBee);
        }

        public void CollectHoney(int days){
            foreach (Bees x in this.bees) {
                float Amount = days * x.Size * 0.2F;
                System.Console.WriteLine("Honey Collected by " + x.Name + " is: " + Amount);
            }
        }
    }
}