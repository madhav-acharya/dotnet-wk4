// See https://aka.ms/new-console-template for more information

using Task_1;
public class  Program
{
    public static void Main()
    {
        Student s1 = new Student("Madhav", 23, 3.8);
        Student s2 = new Student("Santosh", 18, 3.6);

        Console.WriteLine("Student 1:");
        Console.WriteLine($"Name: {s1.name}");
        Console.WriteLine($"Age: {s1.age}");
        Console.WriteLine($"GPA: {s1.gpa}");
        Console.WriteLine();

        Console.WriteLine("Student 2:");
        Console.WriteLine($"Name: {s2.name}");
        Console.WriteLine($"Age: {s2.age}");
        Console.WriteLine($"GPA: {s2.gpa}");
        Console.WriteLine();

        Console.WriteLine($"Total Students: {Student.totalStudents}");
    }
}