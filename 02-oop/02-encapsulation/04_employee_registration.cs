// Create an employee with protected properties, apply a salary increase, and calculate the annual salary.

Employee e1 = new Employee("Carlos", 3000);

Console.WriteLine($"Name: {e1.Name}");
Console.WriteLine($"Initial salary: {e1.MonthlySalary:F2}");

e1.ApplyRaise(10);

Console.WriteLine($"\nUpdated salary: {e1.MonthlySalary:F2}");
Console.WriteLine($"Annual salary: {e1.AnnualSalary:F2}\n");

class Employee(string name, float salary)
{
    public string Name { get; private set; } = name;
    public float MonthlySalary { get; private set; } = salary;

    public float AnnualSalary
    {
        get
        {
            return MonthlySalary * 12;
        }
    }

    public void ApplyRaise(float percentage)
    {
        float increase = MonthlySalary * percentage / 100;

        if (percentage > 0)
        {
            MonthlySalary += increase;
        }
        else
        {
            Console.WriteLine("Invalid percentage");
        }
    }
}
