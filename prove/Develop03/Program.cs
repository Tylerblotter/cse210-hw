using System;

class Program
    {
        static void Main(string[] args)
        {
            sReference reference = new sReference("1 Nephi", 3, 7);
            string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

            Scripture scripture = new Scripture(reference, text);

            Console.WriteLine("Scripture: " + scripture.Reference.Book + " " + scripture.Reference.Chapter + ":" + scripture.Reference.Verse + "\n" + scripture.Text);

            string[] words = scripture.Text.Split(' ');
            int wordCount = words.Length;
            int hiddenCount = 0;

            while (hiddenCount < wordCount)
            {
                Console.WriteLine("\nPress Enter to hide more words or type 0 to exit: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "0")
                {
                    break;
                }

                int randomIndex = new Random().Next(0, wordCount - hiddenCount);
                words[randomIndex] = "_____";
                hiddenCount++;

                Console.Clear();
                Console.WriteLine("Scripture: " + scripture.Reference.Book + " " + scripture.Reference.Chapter + ":" + scripture.Reference.Verse + "\n" + string.Join(" ", words));
            }
        }
    }