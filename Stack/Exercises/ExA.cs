namespace Stack.Exercises;

using Stack.Classes;
using Stack.Interfaces;

public class ExA : IExercise
{
    public void Resolve()
    {
        Console.Write("Number to enqueue: ");
        var n = int.Parse(Console.ReadLine()!);

        StackClass.GetCurrentStack().Push(n);

        Console.WriteLine($"{n} pushed!");
    }
}