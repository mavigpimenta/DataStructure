namespace Array.Exercises;

using Array.Interfaces;

public class Ex6 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of inputs: ");
        var n = int.Parse(Console.ReadLine()!);

        var people = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine()!.Split(' ');
            people.Add(line[0], int.Parse(line[1]));
        }

        Console.WriteLine($"Oldest person: {people.MaxBy(obj => obj.Value).Key}");
    }
}
