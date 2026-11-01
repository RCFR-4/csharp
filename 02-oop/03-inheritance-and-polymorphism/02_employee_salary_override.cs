// Calculate employee and manager salaries using virtual and overridden methods.

Employee e1 = new Employee();
e1.Name = "Ana";
e1.BaseSalary = 3000;

Manager m1 = new Manager();
m1.Name = "Carlos";
m1.BaseSalary = 5000;
m1.Bonus = 1500;

Console.WriteLine($"Name: {e1.Name}");
Console.WriteLine($"Salary: {e1.CalculateSalary()}");

Console.WriteLine($"\nName: {m1.Name}");
Console.WriteLine($"Salary: {m1.CalculateSalary()}");

class Employee
{
    public string Name { get; set; } = "";
    public float BaseSalary { get; set; }

    public virtual float CalculateSalary()
    {
        return BaseSalary;
    }
}

class Manager : Employee
{
    public float Bonus { get; set; }

    public override float CalculateSalary()
    {
        return BaseSalary + Bonus;
    }
}
