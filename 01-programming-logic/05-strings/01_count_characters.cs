// Read a full name and display it along with the number of characters, ignoring spaces.

Console.Write("Enter your full name: ");
string n = Console.ReadLine()!;

int tamanho = 0;

for (int i = 0; i < n.Length; i++)
{
    if (n[i] != ' ')
    {
        tamanho++;
    }
}

Console.WriteLine($"\nName entered: {n}");
Console.WriteLine($"\nNumber of characters excluding spaces: {tamanho}");