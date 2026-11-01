// Ask the user for a month and year and display the number of days in that month.

Console.Write("Enter the month number: ");
int month = int.Parse(Console.ReadLine()!);

Console.Write("Enter the year: ");
int year = int.Parse(Console.ReadLine()!);

switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("\nThe month has 31 days");
        break;

    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("\nThe month has 30 days");
        break;

    case 2:
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("\nThe month has 29 days");

        }
        else
        {
            Console.WriteLine("\nThe month has 28 days");
        }
        break;

    default:
        Console.WriteLine("\nInvalid month");
        break;
}