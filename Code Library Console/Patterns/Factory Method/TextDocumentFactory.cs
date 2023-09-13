namespace Code_Library_Console.Patterns.Factory_Method
{
    public class TextDocumentFactory : AbstractDocumentFactory
    {
        public override AbstractDocument CreateDocument(string header, string body, string footer)
        {
            return new TextDocument(header, body, footer);
        }
    }
}
