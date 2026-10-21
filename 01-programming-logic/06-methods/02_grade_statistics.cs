// Read five student grades, calculate the class average using a function, and count how many students scored at or above the average.

float[] n = new float[5];
float average = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter the grade of student {i + 1}: ");
    n[i] = float.Parse(Console.ReadLine()!);
}

float Average(float[] array, int size)
{
    float sum = 0;

    for (int i = 0; i < size; i++)
    {
        sum += array[i];
    }

    return sum / size;
}

average = Average(n, 5);

int AboveAverage(float[] array, int size, float m)
{
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] >= m)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine($"\nClass average: {average:f2}");
Console.WriteLine($"\nStudents with grades at or above the average: {AboveAverage(n, 5, average)}");