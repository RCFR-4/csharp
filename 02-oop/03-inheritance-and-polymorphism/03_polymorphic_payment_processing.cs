
// Process card and Pix payments polymorphically using a shared payment array.

CardPayment p1 = new CardPayment();
PixPayment p2 = new PixPayment();

p1.Amount = 1000;
p1.Fee = 5;
p2.Amount = 1000;
p2.Discount = 10;

Payment[] payments = { p1, p2 };

Console.WriteLine("---Payments---");
foreach (Payment p in payments)
{
    Console.WriteLine(p.CalculateFinalAmount());
}

class Payment
{
    public float Amount { get; set; }

    public virtual float CalculateFinalAmount()
    {
        return Amount;
    }
}

class CardPayment : Payment
{
    public float Fee { get; set; }

    public override float CalculateFinalAmount()
    {
        float extra = Amount * Fee / 100;
        return Amount + extra;
    }
}

class PixPayment : Payment
{
    public float Discount { get; set; }

    public override float CalculateFinalAmount()
    {
        float d = Amount * Discount / 100;
        return Amount - d;
    }
}
