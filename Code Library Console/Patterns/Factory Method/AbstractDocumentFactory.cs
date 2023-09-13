namespace Code_Library_Console.Patterns.Factory_Method
{
    public abstract class AbstractDocumentFactory
    {
        public abstract AbstractDocument CreateDocument(string header, string body, string footer);
    }
}
