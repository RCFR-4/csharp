// Read eight integers and use two functions to calculate their sum and count the even numbers.

int[] n = new int[8];

for (int i = 0; i < n.Length; i++)
{
    Console.Write($"Enter the value at position {i + 1} of the array: ");
    n[i] = int.Parse(Console.ReadLine()!);
}

int Sum(int[] v)
{
    int sum = 0;

    for (int i = 0; i < v.Length; i++)
    {
        sum += v[i];
    }

    return sum;
}

int Even(int[] v)
{
    int count = 0;

    for (int i = 0; i < v.Length; i++)
    {
        if (v[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

Console.Write($"\nTotal sum: {Sum(n)}");
Console.WriteLine($"\nNumber of even elements: {Even(n)}");