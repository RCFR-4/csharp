// Ask the user for the number of rows and columns and display a rectangle using asterisks.

Console.Write("Enter the number of rows: ");
int l = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of columns: ");
int c = int.Parse(Console.ReadLine()!);

if (l <= 0 || c <= 0)
{
    Console.WriteLine("\nEnter a valid quantity");
    return;
}

for (int i = 0; i < l; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}