// See https://aka.ms/new-console-template for more information

namespace Task_5;

class Program
{
    enum DayType
    {
        Weekday,
        Weekend
    }

    record Book(string title, string author, double price);

    static void Main()
    {
        // --- Part 1: DayType ---
        System.Console.Write("Enter the day: ");
        string day = System.Console.ReadLine();

        DayType type = (day == "Friday" || day == "Saturday") ? DayType.Weekend : DayType.Weekday;
        System.Console.WriteLine("It is: " + type);
        System.Console.WriteLine();

        // --- Part 2: Book record ---
        // Create first book object
        Book book1 = new Book("C# in Depth", "Jon Skeet", 49.99);
        // Create second book using 'with' expression
        Book book2 = book1 with { title = "Advanced C#", price = 59.99 };

        // Print first object
        System.Console.WriteLine("First book object:");
        System.Console.WriteLine(book1);
        System.Console.WriteLine();

        // Deconstruct second object
        var (title, author, price) = book2;
        System.Console.WriteLine("Second book deconstructed values:");
        System.Console.WriteLine("Title: " + title);
        System.Console.WriteLine("Author: " + author);
        System.Console.WriteLine("Price: " + price);
    }
}
