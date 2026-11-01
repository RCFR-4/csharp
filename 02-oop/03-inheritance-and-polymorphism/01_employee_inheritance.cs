// Create an employee and a manager to demonstrate inheritance of properties and methods.

Manager m1 = new Manager();
m1.Name = "Carlos";
m1.Salary = 5000;
m1.Department = "Technology";

m1.DisplayInfo();
m1.DisplayDepartment();

class Employee
{
    public string Name { get; set; } = "";
    public float Salary { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary:F2}");
    }
}

class Manager : Employee
{
    public string Department { get; set; } = "";

    public void DisplayDepartment()
    {
        Console.WriteLine($"Department: {Department}");
    }
}
