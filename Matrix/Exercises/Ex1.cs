namespace Matrix.Exercises;

using Matrix.Interfaces;

public class Ex1 : IExercise
{
    public void Resolve()
    {
        Console.Write("Matrix size (M N): ");
        var sizeInput = Console.ReadLine()!.Split(' ');
        int m = int.Parse(sizeInput[0]);
        int n = int.Parse(sizeInput[1]);

        var matrix = new int[m, n];

        Console.WriteLine("Matrix values:");
        for (int i = 0; i < m; i++)
        {
            var row = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
                matrix[i, j] = int.Parse(row[j]);
        }

        Console.WriteLine("Negative values:");
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (matrix[i, j] < 0)
                    Console.WriteLine(matrix[i, j]);
    }
}
