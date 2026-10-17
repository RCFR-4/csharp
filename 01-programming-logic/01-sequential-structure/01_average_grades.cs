// Ask the user for three grades and display the average.

float n1, n2, n3, average;

Console.Write("Enter the first grade: ");
n1 = float.Parse(Console.ReadLine()!);

Console.Write("Enter the second grade: ");
n2 = float.Parse(Console.ReadLine()!);

Console.Write("Enter the third grade: ");
n3 = float.Parse(Console.ReadLine()!);

average = (n1 + n2 + n3) / 3;

Console.WriteLine($"\nThe average is: {average:F2}");