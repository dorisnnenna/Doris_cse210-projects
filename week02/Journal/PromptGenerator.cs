using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What new thing did I learn today?",
        "What made me smile today?",
        "what challenged me today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}