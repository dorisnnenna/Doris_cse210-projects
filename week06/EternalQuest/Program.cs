/*
Additional feature:
To exceed the core requirements, I implemented a simple gamification enhancement by adding a Level System.
The user earns levels based on their total score (1 level per 1000 points). This encourages continued engagement
and provides a visual representation of progress beyond just points.
*/


List<Goal> goals = new List<Goal>();
int score = 0;
int level = 1;

while (true)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Create Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Show Score");
    Console.WriteLine("5. Save");
    Console.WriteLine("6. Load");
    Console.WriteLine("7. Quit");

    Console.Write("Select: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            goals.Add(new SimpleGoal(name, desc, points));

        else if (type == "2")
            goals.Add(new EternalGoal(name, desc, points));

        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    else if (choice == "2")
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
    }

    else if (choice == "3")
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available!");
            continue;
        }

        Console.WriteLine("Select goal:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= goals.Count)
        {
            Console.WriteLine("Invalid selection!");
            continue;
        }

        int earned = goals[index].RecordEvent();
        score += earned;
        level = (score / 1000) + 1;

        Console.WriteLine($"You earned {earned} points!");
    }

    else if (choice == "4")
    {
        level = (score / 1000) + 1;

        Console.WriteLine($"Score: {score}");
        Console.WriteLine($"Level: {level}");
    }

    else if (choice == "5")
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(score);

            foreach (Goal g in goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved!");
    }

    else if (choice == "6")
    {
        goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");

        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal g = new SimpleGoal(name, desc, points);

                if (isComplete)
                {
                    g.RecordEvent();
                }

                goals.Add(g);
            }

            else if (type == "EternalGoal")
            {
                goals.Add(new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3])
                ));
            }

            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                int current = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal g = new ChecklistGoal(name, desc, points, target, bonus, current);

                for (int j = 0; j < current; j++)
                {
                    g.RecordEvent();
                }

                goals.Add(g);
            }
        }

        Console.WriteLine("Loaded successfully!");
    }

    else if (choice == "7")
    {
        break;
    }
}