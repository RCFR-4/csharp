// Create a generic inventory class to manage items of different types using List<T>.

Inventory<string> p1 = new Inventory<string>();
p1.AddItem("Mouse");
p1.AddItem("Keyboard");
p1.AddItem("Monitor");
p1.RemoveItem("Keyboard");
p1.RemoveItem("Printer");

Inventory<int> c1 = new Inventory<int>();
c1.AddItem(101);
c1.AddItem(102);
c1.AddItem(103);
c1.RemoveItem(102);

Console.WriteLine($"---Code inventory---\nQuantity: {c1.CountItems()}");
foreach (int code in c1.Items)
{
    Console.WriteLine(code);
}

Console.WriteLine($"\n---Product inventory---\nQuantity: {p1.CountItems()}");
foreach (string product in p1.Items)
{
    Console.WriteLine(product);
}

Console.WriteLine();

class Inventory<T>
{
    public List<T> Items { get; private set; } = new List<T>();

    public void AddItem(T item)
    {
        Items.Add(item);
    }

    public void RemoveItem(T item)
    {
        if (!Items.Remove(item))
        {
            Console.WriteLine("Item not found");
        }
    }

    public int CountItems()
    {
        return Items.Count;
    }
}
