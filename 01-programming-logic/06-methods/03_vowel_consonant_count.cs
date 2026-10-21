// Read a word and use two functions to count its vowels and consonants, then display both results.

Console.Write("Enter a word: ");
string p = Console.ReadLine()!;

int Vowels(string word)
{
    int count_vowels = 0;

    for (int i = 0; i < word.Length; i++)
    {
        if ((word[i] == 'a' || word[i] == 'A') || (word[i] == 'e' || word[i] == 'E') || (word[i] == 'i' || word[i] == 'I') || (word[i] == 'o' || word[i] == 'O') || (word[i] == 'u' || word[i] == 'U'))
        {
            count_vowels++;
        }
    }

    return count_vowels;
}

int Consonants(string word)
{
    int count_consonants = 0;

    for (int i = 0; i < word.Length; i++)
    {
        if ((word[i] != 'a' && word[i] != 'A') && (word[i] != 'e' && word[i] != 'E') && (word[i] != 'i' && word[i] != 'I') && (word[i] != 'o' && word[i] != 'O') && (word[i] != 'u' && word[i] != 'U'))
        {
            count_consonants++;
        }
    }

    return count_consonants;
}

Console.WriteLine($"\nTotal vowels: {Vowels(p)}");
Console.WriteLine($"\nTotal consonants: {Consonants(p)}");