using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "When have you felt happy this month?",
        "Who are your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by listing as many items as you can.")
    {
    }

    public void Run()
    {
        Start();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        int count = 0;
        int duration = GetDuration();

        Stopwatch timer = new Stopwatch();
        timer.Start();

        Console.WriteLine("\nStart listing items:");

        while (timer.Elapsed.TotalSeconds < duration)
        {
            Console.Write("> ");
            Console.ReadLine(); // user input
            count++;
        }

        timer.Stop();

        Console.WriteLine($"\nYou listed {count} items!");

        End();
    }
}