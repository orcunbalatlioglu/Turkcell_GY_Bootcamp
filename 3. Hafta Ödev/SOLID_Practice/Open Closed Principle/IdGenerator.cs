namespace OpenClosedPrinciple
{

    public class IdGenerator
    {
        private static int currentId = 0;

        public static int NextId()
        {
            currentId++;
            return currentId;
        }
    }
    
}
