// Create an order that manages its own items and calculates subtotals and the total cost.

Order o1 = new Order();
o1.AddItem("Mouse", 50, 2);
o1.AddItem("Keyboard", 100, 1);
o1.AddItem("Monitor", 800, 1);

Console.WriteLine("---Order items---");
o1.DisplayItems();
Console.WriteLine();
Console.WriteLine($"Order total: {o1.CalculateTotal():F2}");

class OrderItem(string name, float price, int quantity)
{
    public string Name { get; } = name;
    public float Price { get; } = price;
    public int Quantity { get; } = quantity;

    public float CalculateSubtotal()
    {
        return Price * Quantity;
    }
}

class Order
{
    private List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public void AddItem(string name, float price, int quantity)
    {
        OrderItem item = new OrderItem(name, price, quantity);
        Items.Add(item);
    }

    public float CalculateTotal()
    {
        float sum = 0;

        foreach (OrderItem item in Items)
        {
            sum += item.CalculateSubtotal();
        }

        return sum;
    }

    public void DisplayItems()
    {
        foreach (OrderItem item in Items)
        {
            Console.WriteLine($"{item.Name} - Quantity: {item.Quantity} - Subtotal: {item.CalculateSubtotal()}");
        }
    }
}
