namespace Code_Library_Console.Patterns.Factory
{
    class DatabaseDataAccessorFactory : AbstractDataAccessorFactory
    {
        public override AbstractDataAccessor CreateDataAccessor()
        {
            return new DBAccessor();
        }
    }
}
