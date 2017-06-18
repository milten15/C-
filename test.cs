namespace IMJunior
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Room r = new Room();
        }
    }

    class Room
    {
        private static int id = 0;
        int i;

        public Room()
        {
            i = id++;
        }
    }

    class Environment
    {
        
    }
}
