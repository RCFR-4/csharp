// Create two products with predefined values, add five units to the first product, and display their updated inventory values.

Product p1 = new Product("Mouse", 50, 3);
Product p2 = new Product("Keyboard", 100, 2);

p1.Quantity += 5;

Console.WriteLine("\n--- Updated Inventory ---");

Console.WriteLine($"Product: {p1.Name}");
Console.WriteLine($"Quantity: {p1.Quantity}");
Console.WriteLine($"Inventory value: {p1.CalculateTotal():F2}");

Console.WriteLine($"\nProduct: {p2.Name}");
Console.WriteLine($"Quantity: {p2.Quantity}");
Console.WriteLine($"Inventory value: {p2.CalculateTotal():F2}");

class Product(string name, float price, int quantity)
{
    public string Name = name;
    public float Price = price;
    public int Quantity = quantity;

    public float CalculateTotal()
    {
        return Quantity * Price;
    }
}
