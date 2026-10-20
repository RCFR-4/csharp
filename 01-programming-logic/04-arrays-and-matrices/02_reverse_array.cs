// Read five integers into an array and store them in reverse order in another array.

int[] v = new int[5];
int[] v2 = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter the {i + 1} value of the array: ");
    v[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 5; i++)
{
    v2[i] = v[4 - i];
}

Console.WriteLine("\nReversed array:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\n{v2[i]}");
}