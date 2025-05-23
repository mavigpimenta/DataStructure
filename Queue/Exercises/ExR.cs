namespace Queue.Exercises;

using Queue.Classes;
using Queue.Interfaces;

public class ExR : IExercise
{
    public void Resolve()
    {
        var n = QueueClass.GetCurrentQueue().Dequeue();

        Console.WriteLine($"{n} dequeued!");
    }
}