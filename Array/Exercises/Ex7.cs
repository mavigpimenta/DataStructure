namespace Array.Exercises;

using Array.Interfaces;

public class Ex7 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of inputs: ");
        var n = int.Parse(Console.ReadLine()!);

        var students = new Dictionary<string, bool>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine()!.Split(' ');

            var average = (double.Parse(line[1]) + double.Parse(line[2])) / 2;
            students.Add(line[0], average >= 6);
        }

        Console.WriteLine($"Approved students: {string.Join(", ", students.Where(obj => obj.Value).Select(obj => obj.Key))}");
    }
}
