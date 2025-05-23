namespace Stack.Exercises;

using Stack.Classes;
using Stack.Interfaces;

public class ExV : IExercise
{
    public void Resolve()
    {
        Console.WriteLine($"[{String.Join(", ", StackClass.GetCurrentStack().Stack)}]");
    }
}