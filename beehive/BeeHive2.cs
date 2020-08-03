namespace beehive
{
    public class BeeHive2
    {
        bee Kurt;
        bee Dave;
        bee Krist;
        public void AddBees(Bee newBee)
        {
            if (Kurt == null)
            {
                Kurt = newBee;
            }
            else if (Dave == null)
            {
                Dave = newBee;
            }
            else
            {
                Krist = newBee;
            }
        }
    }
}