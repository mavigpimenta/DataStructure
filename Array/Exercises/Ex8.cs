namespace Array.Exercises;

using Array.Interfaces;

public class Ex8 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of inputs: ");
        var n = int.Parse(Console.ReadLine()!);

        var people = new Dictionary<double, string>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine()!.Split(' ');
            people.Add(double.Parse(line[0]), line[1]);
        }

        Console.WriteLine($"Shorter height: {people.Min(obj => obj.Key)}");
        Console.WriteLine($"Greatest height: {people.Max(obj => obj.Key)}");
        Console.WriteLine($"Average height of women: {people.Where(obj => obj.Value == "F").Average(obj => obj.Key)}");
        Console.WriteLine($"Number of men: {people.Count(obj => obj.Value == "M")}");
    }
}
