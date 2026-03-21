using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running = true;

        while(running)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen. GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write(">");
                string response = Console.ReadLine();

                Entry entry = new Entry ();
                entry._prompt = prompt;
                entry._response = response;
                entry._date = DateTime.Now.ToShortDateString();


                journal.AddEntry(entry);

            }
            else if (choice == "2")
            {
                journal.DisplayAll();

            }

            else if (choice == "3")

            {
                Console.Write("Filename:");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == "5")
            {
                running = false;
            }
        }
    }
}


