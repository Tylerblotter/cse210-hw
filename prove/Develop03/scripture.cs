    public class Scripture
    {
        public sReference Reference { get; set; }
        public string Text { get; set; }

        public Scripture(sReference reference, string text)
        {
            Reference = reference;
            Text = text;
        }
    }