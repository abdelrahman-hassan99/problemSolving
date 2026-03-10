using System;
using System.Collections.Generic;

public class NotesStore
{
    public static void Main()
    {
        NotesStore store = new NotesStore();

        store.AddNote("active", "DrinkTea");
        store.AddNote("active", "DrinkCoffee");
        store.AddNote("completed", "Study");

        Console.WriteLine(string.Join(", ", store.GetNotes("active")));     // Output: DrinkTea, DrinkCoffee
        Console.WriteLine(string.Join(", ", store.GetNotes("completed")));  // Output: Study
        Console.WriteLine(string.Join(", ", store.GetNotes("others")));     // Output: (empty)
    }

    private readonly Dictionary<string, List<string>> notes;

    private readonly HashSet<string> validStates = new HashSet<string>
    {
        "completed", "active", "others"
    };

    public NotesStore()
    {
        notes = new Dictionary<string, List<string>>
        {
            {"completed", new List<string>()},
            {"active", new List<string>()},
            {"others", new List<string>()}
        };
    }

    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be empty");
        }

        if (!validStates.Contains(state))
        {
            throw new Exception($"Invalid state {state}");
        }

        notes[state].Add(name);
    }

    public List<string> GetNotes(string state)
    {
        if (!validStates.Contains(state))
        {
            throw new Exception($"Invalid state {state}");
        }

        return new List<string>(notes[state]);
    }
}
