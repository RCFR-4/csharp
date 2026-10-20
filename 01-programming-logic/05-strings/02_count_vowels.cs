// Read a text and display the total number of vowels it contains.

Console.Write("Enter a text: ");
string p = Console.ReadLine()!;

int contador = 0;

for (int i = 0; i < p.Length; i++)
{
    if ((p[i] == 'a' || p[i] == 'A') || (p[i] == 'e' || p[i] == 'E') || (p[i] == 'i' || p[i] == 'I') || (p[i] == 'o' || p[i] == 'O') || (p[i] == 'u' || p[i] == 'U'))
    {
        contador++;
    }
}

Console.WriteLine($"\nNumber of vowels: {contador}");