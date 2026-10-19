// Ask the user for two numbers and an operator and display the result.

Console.Write("Enter the first value: ");
float n1 = float.Parse(Console.ReadLine()!);

Console.Write("Enter the second value: ");
float n2 = float.Parse(Console.ReadLine()!);

Console.Write("Enter the desired operation (- + * /): ");
char operation = char.Parse(Console.ReadLine()!);

switch (operation)
{
    case '-':
        Console.WriteLine($"\nSubtraction: {n1 - n2:f2}");
        break;

    case '+':
        Console.WriteLine($"\nSum: {n1 + n2:f2}");
        break;

    case '*':
        Console.WriteLine($"\nMultiplication: {n1 * n2:f2}");
        break;

    case '/':
        if (n2 == 0)
        {
            Console.WriteLine("\nCannot divide by zero");
            break;

        }
        else
        {
            Console.WriteLine($"\nDivision: {n1 / n2:f2}");
            break;
        }

    default:
        Console.WriteLine("\nInvalid. Choose a valid operation");
        break;
}