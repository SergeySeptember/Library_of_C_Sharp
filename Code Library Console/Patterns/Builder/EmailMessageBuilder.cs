namespace Code_Library_Console.Patterns.Builder
{
    public class EmailMessageBuilder
    {
        private readonly EmailMassage _emailMassage = new();

        public EmailMessageBuilder From(string emailAddress)
        {
            _emailMassage.From = emailAddress;
            return this;
        }

        public EmailMessageBuilder To(string emailAddress)
        {
            _emailMassage.To = emailAddress;
            return this;
        }

        public EmailMessageBuilder Subject(string subject)
        {
            _emailMassage.Subject = subject;
            return this;
        }

        public EmailMessageBuilder Body(string body)
        {
            _emailMassage.Body = body;
            return this;
        }

        public EmailMessageBuilder AttachedFile(byte[] file)
        {
            _emailMassage.AttachedFile = file;
            return this;
        }

        public EmailMassage Build()
        {
            if (_emailMassage.From is null)
                throw new ArgumentException();
            if (_emailMassage.To is null)
                throw new ArgumentException();
            if (_emailMassage.Subject is null)
                throw new ArgumentException();
            if (_emailMassage.Body is null)
                throw new ArgumentException();

            return _emailMassage;
        }
    }
}