using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        bool run = true;
        while(run == true){
            Console.Write($"\nMenu:\n1. Write a new Entry\n2. Display the Journal\n3. Save current Journal\n4. Load a saved Journal\n5. Done\n--> ");
            string inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);

            if (input == 1){
                journal1.createNewEntry();
            }
            else if (input == 2){
                Console.WriteLine("Journal Entries: ");
                journal1.displayEntries();
            }
            else if (input == 3){
                journal1.saveEntry();
            }
            else if (input == 4){
                journal1.readEntry();
            }
            else if (input == 5){
                run = false;
            }
            else{
                Console.WriteLine("Invalid input, enter 1-5");
            }
        }
    }
}