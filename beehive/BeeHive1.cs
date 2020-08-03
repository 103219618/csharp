namespace beehive
{
    public class BeeHive1
    {
        bee John;
        bee Paul;
        bee George;
        bee Ringo;
        public void AddBees(Bee newBee) {
            if (John == null) {
                John = newBee;
            }  else if (Paul == null) {
                Paul = newBee;
            } else if (George == null){
                George = newBee;
            }
            else {
                Ringo = newBee;
            }
        }
    }
}