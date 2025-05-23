namespace Queue.Exercises;

using Queue.Classes;
using Queue.Interfaces;

public class ExA : IExercise
{
    public void Resolve()
    {
        Console.Write("Number to enqueue: ");
        var n = int.Parse(Console.ReadLine()!);

        QueueClass.GetCurrentQueue().Enqueue(n);

        Console.WriteLine($"{n} enqueued!");
    }
}