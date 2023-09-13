namespace Code_Library_Console.Patterns.Factory
{
    class WebServiceDataAccessorFactory : AbstractDataAccessorFactory
    {
        public override AbstractDataAccessor CreateDataAccessor()
        {
            return new WebServiceDataAccessor();
        }
    }
}
