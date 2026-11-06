// Create an employee management system using an abstract class and a bonus interface.

Employee e1 = new RegularEmployee();
e1.Name = "Ana";
e1.BaseSalary = 3000;

Manager m1 = new Manager();
m1.Name = "Carlos";
m1.BaseSalary = 5000;
m1.BonusPercentage = 10;

Employee[] employees = { e1, m1 };

foreach (Employee emp in employees)
{
    Console.WriteLine($"Name: {emp.Name}");
    Console.WriteLine($"Salary: {emp.CalculateSalary():F2}\n");
}

Console.WriteLine($"Manager bonus: {m1.CalculateBonus():F2}");

abstract class Employee
{
    public string Name { get; set; } = "";
    public float BaseSalary { get; set; }

    public abstract float CalculateSalary();
}

interface IBonusEligible
{
    float CalculateBonus();
}

class RegularEmployee : Employee
{
    public override float CalculateSalary()
    {
        return BaseSalary;
    }
}

class Manager : Employee, IBonusEligible
{
    public float BonusPercentage { get; set; }

    public float CalculateBonus()
    {
        float bonus = BaseSalary * BonusPercentage / 100;
        return bonus;
    }

    public override float CalculateSalary()
    {
        float total = BaseSalary + CalculateBonus();
        return total;
    }
}
