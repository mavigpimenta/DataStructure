namespace Stack.Exercises;

using Stack.Classes;
using Stack.Interfaces;

public class ExR : IExercise
{
    public void Resolve()
    {
        var n = StackClass.GetCurrentStack().Pop();

        Console.WriteLine($"{n} popped!");
    }
}