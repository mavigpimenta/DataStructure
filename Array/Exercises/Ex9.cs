namespace Array.Exercises;

using Array.Interfaces;

public class Ex9 : IExercise
{
    public void Resolve()
    {
        Console.Write("Number of inputs: ");
        var n = int.Parse(Console.ReadLine()!);

        var products = new List<(double purchase, double sale)>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine()!.Split(' ');
            var purchase = double.Parse(line[1]);
            var sale = double.Parse(line[2]);
            products.Add((purchase, sale));
        }

        var totalPurchase = products.Sum(p => p.purchase);
        var totalSale = products.Sum(p => p.sale);

        Console.WriteLine($"Profit below 10%: {products.Count(p => (p.sale - p.purchase) / p.purchase < 0.10)}");
        Console.WriteLine($"Profit between 10% and 20%: {products.Count(p => (p.sale - p.purchase) / p.purchase >= 0.10 && (p.sale - p.purchase) / p.purchase <= 0.20)}");
        Console.WriteLine($"Profit above 20%: {products.Count(p => (p.sale - p.purchase) / p.purchase > 0.20)}");
        Console.WriteLine($"Total purchase value: {totalPurchase}");
        Console.WriteLine($"Total sale value: {totalSale}");
        Console.WriteLine($"Total profit: {totalSale - totalPurchase}");
    }
}
