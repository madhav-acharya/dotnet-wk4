namespace Task_1;

public class Student
{
    public string name; 
    public int age;      
    public double gpa;

    public static int totalStudents;

    public Student(string name, int age, double gpa)
    {
        this.name = name;
        this.age = age;
        this.gpa = gpa;
        totalStudents++;
    }
}
