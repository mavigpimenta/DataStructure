namespace Matrix.Exercises;

using Matrix.Interfaces;

public class Ex2 : IExercise
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
            int sum = 0;
            for (int j = 0; j < n; j++)
                sum += matrix[i, j];
            Console.WriteLine(sum);
        }
    }
}
