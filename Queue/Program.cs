using System.Globalization;
using Queue.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: dotnet run <ExerciseClass>");
            return;
        }

        string className = $"Stack.Exercises.{args[0]}";
        Type? type = Type.GetType(className);

        if (type is null || !typeof(IExercise).IsAssignableFrom(type))
        {
            Console.WriteLine($"Error: Class '{args[0]}' not found or does not implement IExercise.");
            return;
        }

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

        var instance = Activator.CreateInstance(type) as IExercise;
        instance?.Resolve();
    }
}
