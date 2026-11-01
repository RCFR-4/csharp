// Ask the user for days, hours, and minutes and display the total time in minutes.

Console.Write("Enter the number of days: ");
int days = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of hours: ");
int hours = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of minutes: ");
int minutes = int.Parse(Console.ReadLine()!);

int total_minutes = (days * 1440) + (hours * 60) + minutes;

Console.Write($"\nThe total time in minutes is: {total_minutes}\n");