// Create a product with properties and validate price changes to prevent negative values.

Product p1 = new Product();

p1.Name = "Mouse";
p1.Price = 50;

Console.WriteLine($"Product: {p1.Name}");
Console.WriteLine($"Initial price: {p1.Price}");

p1.Price = -20;
Console.WriteLine($"Price after invalid attempt: {p1.Price}");

p1.Price = 80;
Console.WriteLine($"Final price: {p1.Price}");

class Product
{
    public string Name { get; set; } = "";
    private float price;

    public float Price
    {
        get
        {
            return price;
        }

        set
        {
            if (value >= 0)
            {
                price = value;
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }
    }
}
