
// Create a student class with a name, age, and course. Instantiate a student with predefined values and display the student's information.

Student s = new Student("John", 20, "Software Engineering");

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
