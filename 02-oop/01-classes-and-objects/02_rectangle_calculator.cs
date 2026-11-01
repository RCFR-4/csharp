
// Create a rectangle with predefined dimensions and calculate its area, perimeter, and whether it is a square.

Rectangle r1 = new Rectangle(5, 3);

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
