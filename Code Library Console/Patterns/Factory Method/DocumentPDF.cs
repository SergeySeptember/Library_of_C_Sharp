namespace Code_Library_Console.Patterns.Factory_Method
{
    internal class DocumentPDF : AbstractDocument
    {
        public DocumentPDF(string header, string body, string footer) : base(header, body, footer)
        {
            Header = header + "Text document \n ----------";
            Body = body + "\n ----------";
            Footer = footer;
            Extenstion = ".pdf";
        }
    }
}
