
// Create a shopping cart item with controlled quantity updates and a calculated total value.

ShoppingCartItem item1 = new ShoppingCartItem("Mouse", 50, 3);

Console.WriteLine($"Initial total value: {item1.TotalValue}");

item1.AddUnits(4);
item1.RemoveUnits(2);
item1.RemoveUnits(10);

Console.WriteLine($"\nName: {item1.Name}");
Console.WriteLine($"Unit price: {item1.Price}");
Console.WriteLine($"Final quantity: {item1.Quantity}");
Console.WriteLine($"Final total value: {item1.TotalValue}\n");

class ShoppingCartItem(string name, float price, int quantity)
{
    public string Name { get; private set; } = name;
    public float Price { get; private set; } = price;
    public int Quantity { get; private set; } = quantity;

    public void AddUnits(int quantity)
    {
        if (quantity > 0)
        {
            Quantity += quantity;
        }
        else
        {
            Console.WriteLine("Invalid quantity");
        }
    }

    public void RemoveUnits(int quantity)
    {
        if (quantity <= Quantity && quantity > 0)
        {
            Quantity -= quantity;
        }
        else
        {
            Console.WriteLine("Invalid removal");
        }
    }

    public float TotalValue
    {
        get
        {
            return Price * Quantity;
        }
    }
}
