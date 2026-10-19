// Ask the user for an integer and display whether it is a prime number.

Console.Write("Enter an integer greater than 1: ");
int n = int.Parse(Console.ReadLine()!);

int p = 0;

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        p++;
    }
}

if (p == 2)
{
    Console.WriteLine("\nThe entered number is prime");

}
else
{
    Console.WriteLine("\nThe entered number is not prime");
}