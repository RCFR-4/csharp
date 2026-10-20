// Read a text, analyze its characters, and display the number of letters, digits, and spaces.

Console.Write("Enter a text: ");
string t = Console.ReadLine()!;

int cont_l = 0;
int cont_n = 0;
int cont_e = 0;

for (int i = 0; i < t.Length; i++)
{
    if ((t[i] >= 'a' && t[i] <= 'z') || (t[i] >= 'A' && t[i] <= 'Z'))
    {
        cont_l++;
    }

    if (t[i] == ' ')
    {
        cont_e++;
    }

    if (t[i] >= '0' && t[i] <= '9')
    {
        cont_n++;
    }
}

Console.WriteLine($"\nText entered: {t}");
Console.WriteLine($"\nLetters: {cont_l}");
Console.WriteLine($"Digits: {cont_n}");
Console.WriteLine($"Spaces: {cont_e}");