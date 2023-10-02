using System;

public abstract class Worker
{
    public string Name { get; }

    public string Position { get; protected set; }

    public string WorkDay { get; protected set; }

    public Worker(string name)
    {
        Name = name;
        WorkDay = string.Empty;
    }

     public abstract void FillWorkDay();

    public void Call()
    {
        this.WorkDay += "Calling ";
    }

    public void WriteCode()
    {
        this.WorkDay += "Writing code ";
    }

    public void Relax()
    {
        this.WorkDay += "Relax ";
    }
}
