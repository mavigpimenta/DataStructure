namespace Matrix.Exercises;

using Matrix.Interfaces;

public class Ex5 : IExercise
{
    public void Resolve()
    {
        Console.Write("Matrix size (M N): ");
        var sizeInput = Console.ReadLine()!.Split(' ');
        int m = int.Parse(sizeInput[0]);
        int n = int.Parse(sizeInput[1]);

        var a = new int[m, n];
        var b = new int[m, n];
        var c = new int[m, n];

        Console.WriteLine("Matrix A:");
        for (int i = 0; i < m; i++)
        {
            var row = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
                a[i, j] = int.Parse(row[j]);
        }

        Console.WriteLine("Matrix B:");
        for (int i = 0; i < m; i++)
        {
            var row = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
                b[i, j] = int.Parse(row[j]);
        }

        Console.WriteLine("Resulting matrix C:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
                Console.Write(c[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
