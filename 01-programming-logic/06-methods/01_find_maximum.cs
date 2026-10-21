// Read five integers, find the largest value using a function, and display the result.

int[] v = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter the value {i + 1} of the array: ");
    v[i] = int.Parse(Console.ReadLine()!);
}

int Maximum(int[] array, int size)
{
    int largest = array[0];

    for (int i = 0; i < size; i++)
    {
        if (largest <= array[i])
        {
            largest = array[i];
        }
    }

    return largest;
}

Console.WriteLine($"\nLargest value entered: {Maximum(v, 5)}");