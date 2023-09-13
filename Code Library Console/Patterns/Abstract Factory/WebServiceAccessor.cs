namespace Code_Library_Console.Patterns.Factory
{
    class WebServiceDataAccessor : AbstractDataAccessor
    {
        public override void GetData()
        {
            Console.WriteLine("Getting data from the web service...");
        }
    }
}
