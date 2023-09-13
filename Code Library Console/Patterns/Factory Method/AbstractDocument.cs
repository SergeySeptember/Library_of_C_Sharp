namespace Code_Library_Console.Patterns.Factory_Method
{
    public abstract class AbstractDocument
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        public AbstractDocument(string header, string body, string footer)
        {
            Header = header;
            Body = body;
            Footer = footer;
        }
    }
}
