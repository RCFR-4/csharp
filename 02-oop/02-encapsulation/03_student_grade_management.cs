// Create a student class with grade validation, bonus adjustments, and approval status.

Student s1 = new Student();

s1.Name = "Carlos";
s1.Grade = 5;
s1.AddBonus(2);
s1.Grade = -3;
s1.AddBonus(5);

Console.WriteLine($"Name: {s1.Name}");
Console.WriteLine($"Final grade: {s1.Grade}");
Console.WriteLine($"Status: {s1.CheckApproval()}\n");

class Student
{
    public string Name { get; set; } = "";
    private float grade;

    public float Grade
    {
        get
        {
            return grade;
        }

        set
        {
            if (value >= 0 && value <= 10)
            {
                grade = value;
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }
    }

    public void AddBonus(float bonus)
    {
        if (grade + bonus > 10)
        {
            grade = 10;
        }
        else if (bonus >= 0)
        {
            grade += bonus;
        }
    }

    public string CheckApproval()
    {
        if (grade >= 6)
        {
            return "Approved";
        }
        else
        {
            return "Failed";
        }
    }
}
