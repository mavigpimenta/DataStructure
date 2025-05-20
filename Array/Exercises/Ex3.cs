namespace Array.Exercises;

using Array.Interfaces;

public class Ex3 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of inputs: ");
        var n = int.Parse(Console.ReadLine()!);

        Console.Write("Inputs 1: ");
        var input1 = Console.ReadLine()!.Split(' ');

        var numbers1 = new int[n];

        for (int i = 0; i < n; i++)
            numbers1[i] = int.Parse(input1[i]);

        Console.Write("Inputs 2: ");
        var input2 = Console.ReadLine()!.Split(' ');

        var numbers2 = new int[n];

        for (int i = 0; i < n; i++)
            numbers2[i] = int.Parse(input2[i]);

        var output = new int[n];

        for (int i = 0; i < n; i++)
            output[i] = numbers1[i] + numbers2[i];

        Console.WriteLine($"Sum: {string.Join(" ", output)}");

    }
}
