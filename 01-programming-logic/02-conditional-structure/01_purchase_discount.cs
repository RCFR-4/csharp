// Ask the user for a purchase amount and apply a discount according to the total value.

Console.Write("Enter the total purchase amount: ");
float v_total = float.Parse(Console.ReadLine()!);

float discount;
float v_final;

if (v_total >= 500)
{
    discount = v_total * 15 / 100;
    v_final = v_total - discount;
    Console.WriteLine($"\nThe final price with discount is: {v_final:f2}");

}
else if (v_total >= 200)
{
    discount = v_total * 10 / 100;
    v_final = v_total - discount;
    Console.WriteLine($"\nThe final price with discount is: {v_final:f2}");

}
else
{
    Console.WriteLine("\nNo discount");
}