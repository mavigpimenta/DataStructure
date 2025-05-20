namespace Matrix.Exercises;

using Matrix.Interfaces;

public class Ex4 : IExercise
{
    public void Resolve()
    {
        Console.Write("Matrix size (N): ");
        int n = int.Parse(Console.ReadLine()!);

        var matrix = new int[n, n];

        Console.WriteLine("Matrix values:");
        for (int i = 0; i < n; i++)
        {
            var row = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
                matrix[i, j] = int.Parse(row[j]);
        }

        int sum = 0;

        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                sum += matrix[i, j];

        Console.WriteLine($"Sum of elements above main diagonal: {sum}");
    }
}
