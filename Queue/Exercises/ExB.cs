namespace Queue.Exercises;

using Queue.Classes;
using Queue.Interfaces;

public class ExB : IExercise
{
    public void Resolve()
    {
        Console.Write("Number to find: ");
        var n = int.Parse(Console.ReadLine()!);

        var found = QueueClass.GetCurrentQueue().Find(n);

        Console.WriteLine($"{n} is {(found ? "in the queue" : "not in the queue")}!");
    }
}