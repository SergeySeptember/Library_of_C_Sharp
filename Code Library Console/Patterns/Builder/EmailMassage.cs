namespace Code_Library_Console.Patterns.Builder
{
    public class EmailMassage
    {
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public byte[]? AttachedFile { get; set; }

        public override string ToString() => $"Кому {To}, От {From}";
    }
}