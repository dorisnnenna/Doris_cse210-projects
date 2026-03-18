using System;

class Program
{
    static void Main(string[] args)
    {
        // Call function to display welcome message
        DisplayWelcome();

        // Call function to get user's name
        string userName = PromptUserName();

        // Call function to get user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Call function to calculate the square
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call function to display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
