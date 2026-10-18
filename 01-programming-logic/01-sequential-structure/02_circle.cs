// Ask the user for the radius of a circle and display the area and circumference.

Console.Write("Enter the radius of the circle: ");
float radius = float.Parse(Console.ReadLine()!);

float area = 3.14f * radius * radius;
float circumference = 2 * 3.14f * radius;

Console.WriteLine($"Area: {area:f2}");
Console.WriteLine($"Circumference: {circumference:F2}");