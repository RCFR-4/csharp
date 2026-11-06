// Create a generic storage box that stores, retrieves, and updates values of different types.

Box<int> b1 = new Box<int>(100);
Box<string> b2 = new Box<string>("Carlos");
Box<double> b3 = new Box<double>(7.5);

Console.WriteLine("---Initial values---");
Console.WriteLine(b1.GetValue());
Console.WriteLine(b2.GetValue());
Console.WriteLine(b3.GetValue());

b1.UpdateValue(200);
b2.UpdateValue("Ana");
b3.UpdateValue(9.5);

Console.WriteLine("\n---Updated values---");
Console.WriteLine(b1.GetValue());
Console.WriteLine(b2.GetValue());
Console.WriteLine($"{b3.GetValue()}\n");

class Box<T>(T value)
{
    public T Value { get; set; } = value;

    public T GetValue()
    {
        return Value;
    }

    public void UpdateValue(T newValue)
    {
        Value = newValue;
    }
}
