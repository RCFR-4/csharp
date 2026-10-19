// Keep asking the user for integers until 0 is entered, then display the total sum.

int sum = 0;
int n;

do
{
    Console.Write("Enter an integer: ");
    n = int.Parse(Console.ReadLine()!);

    if (n != 0)
    {
        sum += n;
    }

} while (n != 0);

Console.WriteLine($"\nThe sum is: {sum}");