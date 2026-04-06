using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
        "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        Start(); // from base class

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);

            elapsed += 8; // 4 + 4 seconds
        }

        End(); // from base class
    }
}