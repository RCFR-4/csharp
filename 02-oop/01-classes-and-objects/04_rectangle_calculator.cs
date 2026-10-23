// Create a rectangle class to calculate its area, perimeter, and whether it is a square.

Console.Write("Enter the width: ");
float width = float.Parse(Console.ReadLine()!);

Console.Write("Enter the height: ");
float height = float.Parse(Console.ReadLine()!);

Rectangle r1 = new Rectangle(width, height);

Console.WriteLine("\n--- Rectangle Information ---");
Console.WriteLine($"\nArea: {r1.CalculateArea():F2}");
Console.WriteLine($"\nPerimeter: {r1.Perimeter():F2}");
Console.WriteLine($"\nIs it a square? {r1.IsSquare()}");

class Rectangle(float width, float height)
{
    public float Width = width;
    public float Height = height;

    public float CalculateArea()
    {
        return Width * Height;
    }

    public float Perimeter()
    {
        return 2 * (Width + Height);
    }

    public string IsSquare()
    {
        if (Width == Height)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
}