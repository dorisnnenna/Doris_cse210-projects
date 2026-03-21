using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry> (); 
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"You have {_entries.Count} journal entries.\n");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            
        {
            outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
        }
    }
}

public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[]parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);

        }
}

}

    

