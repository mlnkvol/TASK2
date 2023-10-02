using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Team Name: ");
        string teamName = Console.ReadLine();

        Team team = new Team(teamName);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add worker");
            Console.WriteLine("2. Show info about a team");
            Console.WriteLine("3. Show detailed info about a team");
            Console.WriteLine("4. Exit");

            Console.Write("Choose option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter worker's name: ");
                    string workerName = Console.ReadLine();

                    Console.Write("Enter worker's position: ");
                    string workerPosition = Console.ReadLine();

                    Worker newWorker = workerPosition.ToLower() == "розробник"
                        ? new Developer(workerName)
                        : new Manager(workerName);

                    team.AddWorker(newWorker);
                    Console.WriteLine($"{workerName} is added to the team.");
                    break;

                case "2":
                    team.DisplayTeamInfo();
                    break;

                case "3":
                    team.DisplayDetailedTeamInfo();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Wrong choice. Please try again.");
                    break;
            }
        }
    }
}
