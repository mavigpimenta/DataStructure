namespace Queue.Exercises;

using Queue.Classes;
using Queue.Interfaces;

public class ExV : IExercise
{
    public void Resolve()
    {
        Console.WriteLine($"[{String.Join(", ", QueueClass.GetCurrentQueue().Queue)}]");
    }
}