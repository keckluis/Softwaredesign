namespace L07_DesignPatterns
{
    public class IdGenerator
    {
        public static IdGenerator instance;
        private int lastID;

        private IdGenerator()
        {
            lastID = 1;
        }

        public static IdGenerator getInstance()
        {
            if (instance == null)
                instance = new IdGenerator();

            return instance;
        }
        
        public int GenerateNewID()
        {
            return lastID++;
        }
    } 
}