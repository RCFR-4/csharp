// Create a student class and display the student's name, age, and course.

Console.Write("Enter the student's name: ");
string name = Console.ReadLine()!;

Console.Write("Enter the age: ");
int age = int.Parse(Console.ReadLine()!);

Console.Write("Enter the course: ");
string course = Console.ReadLine()!;

Student s = new Student(name, age, course);

Console.WriteLine("\n--- Student Information ---");
Console.WriteLine($"Name: {s.Name}");
Console.WriteLine($"Age: {s.Age}");
Console.WriteLine($"Course: {s.Course}\n");

class Student(string name, int age, string course)
{
    public string Name = name;
    public int Age = age;
    public string Course = course;
}