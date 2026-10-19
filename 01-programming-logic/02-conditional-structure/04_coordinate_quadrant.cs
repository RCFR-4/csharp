// Ask the user for two coordinates and display where the point is located.

Console.Write("Enter the value of the x coordinate: ");
float x = float.Parse(Console.ReadLine()!);

Console.Write("Enter the value of the y coordinate: ");
float y = float.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.WriteLine("\nThe point is in the first quadrant");

}
else if (x < 0 && y > 0)
{
    Console.WriteLine("\nThe point is in the second quadrant");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("\nThe point is in the third quadrant");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("\nThe point is in the fourth quadrant");
}
else if (x == 0 && y != 0)
{
    Console.WriteLine("\nThe point is on the Y axis");
}
else if (x != 0 && y == 0)
{
    Console.WriteLine("\nThe point is on the X axis");

}
else
{
    Console.WriteLine("\nThe point is at the origin");
}