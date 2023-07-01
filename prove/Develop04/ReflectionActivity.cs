using System;
using System.Collections.Generic;
using System.Threading;

// Reflection Activity class
public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
    }

    public override void Start()
    {
        Console.WriteLine("\n{0}\n\n{1}\n", name, description);
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Thread.Sleep(3000);

        Random random = new Random();

        while (duration > 0)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            string question = questions[random.Next(questions.Count)];

            Console.WriteLine("\nPrompt: {0}", prompt);
            Thread.Sleep(1000);
            ShowSpinner(3);

            Console.WriteLine("\nQuestion: {0}", question);
            Thread.Sleep(2000);
            ShowSpinner(3);

            duration -= 5;
        }

        End();
    }
}