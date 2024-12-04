// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

var values = new[] {9, 1, 5, 0};
Console.WriteLine($"Średnia dla [{String.Join(", ", values)}] to: {CalculateAverage(values)}");


static double CalculateAverage(int[] values)
{
    var result = 0;

    for(int i = 0; i < values.Length; i++)
    {
        result += values[i];
    }

    return result / values.Length;
}