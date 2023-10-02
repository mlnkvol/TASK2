using System;
using System.Collections.Generic;

public class Team
{
    private string Name { get; }

    private List<Worker> Workers { get; set; }

    public Team(string name)
    {
        Name = name;
        Workers = new List<Worker>();
    }

    public void AddWorker(Worker worker)
    {
        Workers.Add(worker);
    }

    public void DisplayTeamInfo()
    {
        Console.WriteLine($"Team name: {Name}");
        Console.WriteLine("Workers list:");

        foreach (var worker in Workers)
        {
            Console.WriteLine($"{worker.Name} - {worker.Position}");
        }
    }

    public void DisplayDetailedTeamInfo()
    {
        Console.WriteLine($"Team name: {Name}");
        Console.WriteLine("Detailed information about workers:");

        foreach (var worker in Workers)
        {
            worker.FillWorkDay();
            Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
        }
        Console.WriteLine();
    }
}
