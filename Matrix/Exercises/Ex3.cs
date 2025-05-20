namespace Matrix.Exercises;

using Matrix.Interfaces;

public class Ex3 : IExercise
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

        for (int i = 0; i < n; i++)
        {
            int max = matrix[i, 0];
            for (int j = 1; j < n; j++)
                if (matrix[i, j] > max)
                    max = matrix[i, j];
            Console.WriteLine(max);
        }
    }
}
