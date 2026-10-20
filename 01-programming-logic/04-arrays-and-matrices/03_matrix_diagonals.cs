// Read a 3x3 matrix and display the values of its main and secondary diagonals.

int[,] m = new int[3, 3];
int[] dp = new int[3];
int[] ds = new int[3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter the value at position [{i + 1} {j + 1}] of the matrix: ");
        m[i, j] = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine();
}

int contdp = 0;
int contds = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (i == j)
        {
            dp[contdp] = m[i, j];
            contdp++;
        }

        if (i + j == 2)
        {
            ds[contds] = m[i, j];
            contds++;
        }
    }
}

Console.WriteLine("Main diagonal:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(dp[i]);
}

Console.WriteLine("Secondary diagonal:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(ds[i]);
}