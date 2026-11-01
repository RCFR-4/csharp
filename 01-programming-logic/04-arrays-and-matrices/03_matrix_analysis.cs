// Read a 3x3 matrix, display it, calculate the total sum, and find the largest value and its position.

int[,] m = new int[3, 3];
float sum = 0;
int i_largest = 0;
int j_largest = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter the value at position [{i + 1} {j + 1}] of the matrix: ");
        m[i, j] = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine();
}

float largest = m[0, 0];

Console.WriteLine("Matrix:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{m[i, j]} ");

        sum += m[i, j];

        if (largest <= m[i, j])
        {
            largest = m[i, j];
            i_largest = i + 1;
            j_largest = j + 1;
        }
    }

    Console.WriteLine();
}

Console.WriteLine($"\nTotal sum: {sum}");
Console.WriteLine($"Largest value: {largest}");
Console.WriteLine($"Position of the largest value: [{i_largest}][{j_largest}]");