// Ask the user for three side lengths and display whether they can form a triangle.

Console.Write("Enter the first side: ");
float l1 = float.Parse(Console.ReadLine()!);

Console.Write("Enter the second side: ");
float l2 = float.Parse(Console.ReadLine()!);

Console.Write("Enter the third side: ");
float l3 = float.Parse(Console.ReadLine()!);

if ((l1 + l2 > l3 && l1 + l3 > l2) && (l2 + l1 > l3 && l2 + l3 > l1) && (l3 + l2 > l1 && l3 + l1 > l2))
{
    Console.WriteLine("\nThe sides can form a triangle");
}
else
{
    Console.WriteLine("\nThe sides cannot form a triangle");
}