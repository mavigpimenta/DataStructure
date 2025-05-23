namespace Stack.Exercises;

using Stack.Classes;
using Stack.Interfaces;

public class ExB : IExercise
{
    public void Resolve()
    {
        Console.Write("Number to find: ");
        var n = int.Parse(Console.ReadLine()!);

        var found = StackClass.GetCurrentStack().Find(n);

        Console.WriteLine($"{n} is {(found ? "in the stack" : "not in the stack")}!");
    }
}