// Create an abstract delivery class and calculate shipping costs for standard and express deliveries.

ExpressDelivery ex1 = new ExpressDelivery();
ex1.Distance = 10;
ex1.FixedFee = 15;

StandardDelivery sd1 = new StandardDelivery();
sd1.Distance = 10;

Console.WriteLine("---Deliveries---");
Console.WriteLine($"Standard shipping: {sd1.CalculateShipping():F2}");
Console.WriteLine($"Express shipping: {ex1.CalculateShipping():F2}");

abstract class Delivery
{
    public float Distance { get; set; }

    public abstract float CalculateShipping();
}

class StandardDelivery : Delivery
{
    public override float CalculateShipping()
    {
        return Distance * 2;
    }
}

class ExpressDelivery : Delivery
{
    public float FixedFee { get; set; }

    public override float CalculateShipping()
    {
        return (Distance * 4) + FixedFee;
    }
}
