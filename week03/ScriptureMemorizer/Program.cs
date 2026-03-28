/* additional features. I added a feature that allows the 
program to show the number of words remaining,
helping users track their memorization progress 
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine($"\nWords remaining: {scripture.GetVisibleWordCount()}");

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress Enter to continue or type quit:");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }

}


