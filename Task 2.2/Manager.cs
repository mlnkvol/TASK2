using System;

public class Manager : Worker
{
    private Random random = new Random();

    public Manager(string name) : base(name)
    {
        Position = "Менеджер";
    }

    public override void FillWorkDay()
    {
        int CallsNumber1 = random.Next(1, 11);

        for (int i = 0; i < CallsNumber1; i++)
        {
            Call();
        }

        Relax();

        int CallsNumber2 = random.Next(1, 6);

        for (int i = 0; i < CallsNumber2; i++)
        {
            Call();
        }
    }
}
