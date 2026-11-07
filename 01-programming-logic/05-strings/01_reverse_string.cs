// Read a text and display it in reverse order.

Console.Write("Enter a text: ");
string t = Console.ReadLine()!;

int l = t.Length;

Console.WriteLine();
for (int i = l - 1; i >= 0; i--)
{
    Console.Write($"{t[i]}");
}

Console.WriteLine();