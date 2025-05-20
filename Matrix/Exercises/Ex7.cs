namespace Matrix.Exercises;

using Matrix.Interfaces;

public class Ex7 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of rows and columns (M N): ");
        var dimensions = Console.ReadLine()!.Split(' ');
        int m = int.Parse(dimensions[0]);
        int n = int.Parse(dimensions[1]);

        var matrix = new int[m, n];

        Console.WriteLine("Soldiers formation:");
        for (int i = 0; i < m; i++)
        {
            var row = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
                matrix[i, j] = int.Parse(row[j]);
        }

        Console.Write("Row to rotate (1-based index): ");
        int rotateIndex = int.Parse(Console.ReadLine()!) - 1;

        int last = matrix[rotateIndex, n - 1];
        for (int j = n - 1; j > 0; j--)
            matrix[rotateIndex, j] = matrix[rotateIndex, j - 1];
        matrix[rotateIndex, 0] = last;

        Console.WriteLine("Updated formation:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{matrix[i, j]} ");
            Console.WriteLine();
        }
    }
}
