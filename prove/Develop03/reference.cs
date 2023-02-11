    public class sReference
    {
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public Verse VerseRange { get; set; }

        public sReference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }

        public sReference(string book, int chapter, Verse verseRange)
        {
            Book = book;
            Chapter = chapter;
            VerseRange = verseRange;
        }
    }