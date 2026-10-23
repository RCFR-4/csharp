// Create two products, add five units to the first, and calculate their inventory values.

Console.Write("Enter the product name: ");
string product1Name = Console.ReadLine()!;

Console.Write("Enter the product price: ");
float product1Price = float.Parse(Console.ReadLine()!);

Console.Write("Enter the product quantity: ");
int product1Quantity = int.Parse(Console.ReadLine()!);

Console.Write("\nEnter the product name: ");
string product2Name = Console.ReadLine()!;

Console.Write("Enter the product price: ");
float product2Price = float.Parse(Console.ReadLine()!);

Console.Write("Enter the product quantity: ");
int product2Quantity = int.Parse(Console.ReadLine()!);

Product p1 = new Product(product1Name, product1Price, product1Quantity);
Product p2 = new Product(product2Name, product2Price, product2Quantity);

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