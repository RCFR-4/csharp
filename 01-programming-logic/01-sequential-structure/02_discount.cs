// Ask the user for a product price and discount percentage and display the discount amount and final price.

Console.Write("Enter the product price: ");
float value = float.Parse(Console.ReadLine()!);

Console.Write("Enter the discount percentage: %");
float percent = float.Parse(Console.ReadLine()!);

float discount = (value * percent) / 100;

float final_value = value - discount;

Console.Write($"\nThe discount is: {discount:f2}");
Console.Write($"\nThe final price is: {final_value:f2}\n");