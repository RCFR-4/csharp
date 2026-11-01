// Create a calculator with four arithmetic functions, a repeating menu, invalid-option handling, and division-by-zero protection.

int op;
float n;
float n2;

float Sum(float a, float b)
{
    return a + b;
}

float Subtraction(float a, float b)
{
    return a - b;
}

float Multiplication(float a, float b)
{
    return a * b;
}

float Division(float a, float b)
{
    return a / b;
}

do
{
    Console.WriteLine("------CALCULATOR------");
    Console.WriteLine("1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n0 - Exit");

    Console.Write("\nChoose: ");
    op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 1:
            Console.Write("\nEnter the first number: ");
            n = float.Parse(Console.ReadLine()!);

            Console.Write("Enter the second number: ");
            n2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Result: {Sum(n, n2)}");
            break;

        case 2:
            Console.Write("\nEnter the first number: ");
            n = float.Parse(Console.ReadLine()!);

            Console.Write("Enter the second number: ");
            n2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Result: {Subtraction(n, n2)}");
            break;

        case 3:
            Console.Write("\nEnter the first number: ");
            n = float.Parse(Console.ReadLine()!);

            Console.Write("Enter the second number: ");
            n2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Result: {Multiplication(n, n2)}");
            break;

        case 4:
            Console.Write("\nEnter the first number: ");
            n = float.Parse(Console.ReadLine()!);

            Console.Write("Enter the second number: ");
            n2 = float.Parse(Console.ReadLine()!);

            if (n2 == 0)
            {
                Console.WriteLine("\nDivision by zero is not allowed");
                continue;
            }

            Console.WriteLine($"Result: {Division(n, n2)}");
            break;

        case 0:
            Console.WriteLine("Program closed");
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

} while (op != 0);