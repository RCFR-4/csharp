// Display a menu repeatedly until the user chooses the exit option.

int op = 0;

do
{
    Console.Write("Choose an option: Hello (1), Show message (2), Exit (0): ");
    op = int.Parse(Console.ReadLine()!);

    if (op == 1)
    {
        Console.WriteLine("\nHello!");

    }
    else if (op == 2)
    {
        Console.WriteLine("\nWelcome to the program");
    }
    else if (op != 0 && op != 1 && op != 2)
    {
        Console.WriteLine("\nInvalid option");
    }

    Console.WriteLine();
} while (op != 0);

Console.WriteLine("\nProgram closed");