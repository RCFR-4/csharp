// Ask the user for the total bill and number of people and display how much each person should pay.

Console.Write("Enter the total bill amount: ");
float total_value = float.Parse(Console.ReadLine()!);

Console.Write("Enter the number of people splitting the bill: ");
int quant = int.Parse(Console.ReadLine()!);

float final_value = total_value / quant;

Console.Write($"\nEach person will pay: {final_value:f2}\n");