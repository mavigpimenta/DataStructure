namespace Matrix.Exercises;

using Matrix.Interfaces;

public class Ex6 : IExercise
{
    public void Resolve()
    {
        Console.Write("Matrix size (N): ");
        int n = int.Parse(Console.ReadLine()!);

        var matrix = new double[n, n];

        Console.WriteLine("Matrix values:");
        for (int i = 0; i < n; i++)
        {
            var row = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
                matrix[i, j] = double.Parse(row[j]);
        }

        Console.Write("Chosen row index: ");
        int rowIndex = int.Parse(Console.ReadLine()!);

        Console.Write("Chosen column index: ");
        int colIndex = int.Parse(Console.ReadLine()!);

        double sum = 0.0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (matrix[i, j] > 0)
                    sum += matrix[i, j];

        Console.WriteLine($"Sum of positives: {sum:F1}");

        Console.Write("Chosen row: ");
        for (int j = 0; j < n; j++)
            Console.Write($"{matrix[rowIndex, j]:F1} ");
        Console.WriteLine();

        Console.Write("Chosen column: ");
        for (int i = 0; i < n; i++)
            Console.Write($"{matrix[i, colIndex]:F1} ");
        Console.WriteLine();

        Console.Write("Main diagonal: ");
        for (int i = 0; i < n; i++)
            Console.Write($"{matrix[i, i]:F1} ");
        Console.WriteLine();

        Console.WriteLine("Result matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] < 0)
                    matrix[i, j] = Math.Pow(matrix[i, j], 2);
                Console.Write($"{matrix[i, j]:F1} ");
            }
            Console.WriteLine();
        }
    }
}
