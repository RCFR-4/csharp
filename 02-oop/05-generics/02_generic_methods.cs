// Create a static generic method to compare values of different types.

Console.WriteLine("---Comparisons---");
Console.WriteLine($"Integers equal: {Comparer.AreEqual<int>(10, 10)}");
Console.WriteLine($"Strings equal: {Comparer.AreEqual<string>("Carlos", "ana")}");
Console.WriteLine($"Decimals equal: {Comparer.AreEqual<double>(7.5, 7.5)}\n");

class Comparer
{
    public static bool AreEqual<T>(T first, T second)
    {
        return EqualityComparer<T>.Default.Equals(first, second);
    }
}
