namespace Code_Library_Console.Patterns.Factory_Method
{
    public class TextDocument : AbstractDocument
    {
        public TextDocument(string header, string body, string footer) : base(header, body, footer)
        {
            Header = header + "\n ----------";
            Body = body + "\n ----------";
            Footer = footer;
        }
    }
}
