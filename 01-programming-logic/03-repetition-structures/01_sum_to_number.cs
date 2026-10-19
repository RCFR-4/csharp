// Ask the user for a positive integer and display the sum from 1 up to that number.

Console.Write("Enter a positive integer: ");
int n = int.Parse(Console.ReadLine()!);

int sum = 0;

for (int i = 0; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"\nThe total sum is: {sum}");