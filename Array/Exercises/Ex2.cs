namespace Array.Exercises;

using Array.Interfaces;

public class Ex2 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of inputs: ");
        var n = int.Parse(Console.ReadLine()!);

        Console.Write("Inputs: ");
        var input = Console.ReadLine()!.Split(' ');

        var even = new List<int>();

        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(input[i]);
            if (num % 2 == 0)
                even.Add(num);
        }

        Console.WriteLine($"Even numbers: {string.Join(" ", even)}");
        Console.WriteLine($"Amount: {even.Count}");
    }
}
