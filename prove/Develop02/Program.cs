using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int opt = 0;
        Journal journal = new Journal();

        while (opt != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to to: ");
            opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                journal.SetPrompts();
            }
            else if (opt == 2)
            {
                journal.DisplayJournal();
            }
            else if (opt == 3)
            {
                journal.LoadJournal();
            }
            else if (opt == 4)
            {
                journal.SaveJournal();
            }
        }
    }
}