using System;
using System.Collections.Generic;
using System.Threading;

// Base Activity class
public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public abstract void Start();

    public virtual void End()
    {
        Console.WriteLine("\nCongratulations! You have completed the {0} activity for {1} seconds.", name, duration);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }
}