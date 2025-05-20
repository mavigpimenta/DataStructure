namespace Array.Exercises;

using Array.Interfaces;

public class Ex1 : IExercise
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

        var max = numbers[0];
        int pos = 0;

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                pos = i;
            }
        }

        Console.WriteLine($"Highest value: {max}");
        Console.WriteLine($"Position of highest value: {pos}");
    }
}
