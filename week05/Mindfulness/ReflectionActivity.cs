using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity will help you reflect on times you showed strength and resilience.")
    {
    }

    public void Run()
    {
        Start();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");

        Console.WriteLine("\nTake a moment to think...");
        ShowSpinner(5);

        int duration = GetDuration();
        int elapsed = 0;

        Console.WriteLine("\nNow reflect on these questions:\n");

        while (elapsed < duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine("> " + question);

            ShowSpinner(4); // pause while thinking
            elapsed += 4;
        }

        End();
    }
}