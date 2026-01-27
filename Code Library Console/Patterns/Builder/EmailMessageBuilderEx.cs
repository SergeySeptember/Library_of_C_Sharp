namespace Code_Library_Console.Patterns.Builder
{
    public static class EmailMessageBuilderEx
    {
        public static EmailMassage From(this EmailMassage emailMassage, string from)
        {
            emailMassage.From = from;
            return emailMassage;
        }

        public static EmailMassage To(this EmailMassage emailMassage, string to)
        {
            emailMassage.To = to;
            return emailMassage;
        }

        public static EmailMassage Subject(this EmailMassage emailMassage, string subject)
        {
            emailMassage.Subject = subject;
            return emailMassage;
        }

        public static EmailMassage Body(this EmailMassage emailMassage, string body)
        {
            emailMassage.Body = body;
            return emailMassage;
        }

        public static EmailMassage From(this EmailMassage emailMassage, byte[] fileBytes)
        {
            emailMassage.AttachedFile = fileBytes;
            return emailMassage;
        }

    }
}