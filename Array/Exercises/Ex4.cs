namespace Array.Exercises;

using Array.Interfaces;

public class Ex4 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of inputs: ");
        var n = int.Parse(Console.ReadLine()!);

        Console.Write("Inputs: ");
        var input = Console.ReadLine()!.Split(' ');

        var numbers = new double[n];

        for (int i = 0; i < n; i++)
            numbers[i] = double.Parse(input[i]);

        var average = numbers.Average();

        var belowAverage = new List<double>();

        foreach (var num in numbers)
            if (num < average)
                belowAverage.Add(num);

        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Below average: {string.Join(" ", belowAverage)}");

    }
}
