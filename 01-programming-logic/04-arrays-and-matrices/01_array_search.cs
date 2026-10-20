// Read five integers into an array, search for a number, and display how many times it appears.

int[] v = new int[5];
int n;
int r = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter the value for position {i + 1} of the array: ");
    v[i] = int.Parse(Console.ReadLine()!);
}

Console.Write("Enter the number you want to search for: ");
n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < 5; i++)
{
    if (n == v[i])
    {
        r++;
    }
}

if (r >= 1)
{
    Console.WriteLine($"\nValue found {r} times");
}
else
{
    Console.WriteLine("\nValue not found");
}