namespace Code_Library_Console.Patterns.Factory
{
    public class DBAccessor : AbstractDataAccessor
    {
        public override void GetData()
        {
            Console.WriteLine("Getting data from the database...");
        }
    }
}
