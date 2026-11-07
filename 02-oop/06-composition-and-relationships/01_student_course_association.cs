// Associate students with courses and display their enrollment information.

Course c1 = new Course();
c1.Name = "Software Engineering";
c1.Workload = 3200;

Student s1 = new Student();
s1.Name = "Carlos";
s1.Enrollment = 101;
s1.EnrolledCourse = c1;

Student s2 = new Student();
s2.Name = "Ana";
s2.Enrollment = 102;

s1.DisplayInfo();
Console.WriteLine();
s2.DisplayInfo();

class Course
{
    public string Name { get; set; } = "";
    public int Workload { get; set; }
}

class Student
{
    public string Name { get; set; } = "";
    public int Enrollment { get; set; }
    public Course? EnrolledCourse { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}\nEnrollment: {Enrollment}");

        if (EnrolledCourse != null)
        {
            Console.WriteLine($"Course: {EnrolledCourse?.Name}\nWorkload: {EnrolledCourse?.Workload}");
        }
        else
        {
            Console.WriteLine("Student without a course");
        }
    }
}
