// Read five integers into an array and display its sum, average, largest and smallest values, and how many values are above the average.

int[] v = new int[5];
float sum = 0;
float average = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter the {i + 1} value of the array: ");
    v[i] = int.Parse(Console.ReadLine()!);

    sum += v[i];
}

int largest = v[0];
int smallest = v[0];
int above_average = 0;

average = sum / 5;

for (int i = 0; i < 5; i++)
{
    if (largest <= v[i])
    {
        largest = v[i];
    }

    if (smallest >= v[i])
    {
        smallest = v[i];
    }

    if (v[i] > average)
    {
        above_average += 1;
    }
}

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");
Console.WriteLine($"Largest value: {largest}");
Console.WriteLine($"Smallest value: {smallest}");
Console.WriteLine($"Values above the average: {above_average}");