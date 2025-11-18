// See https://aka.ms/new-console-template for more information

namespace Task_6;

class Program
{
    static void Main()
    {
        // Ask user for marks
        System.Console.Write("Enter marks: ");
        string marksInput = System.Console.ReadLine();

        // Ask user for total
        System.Console.Write("Enter total: ");
        string totalInput = System.Console.ReadLine();

        // TryParse for safe conversion
        bool isMarksValid = int.TryParse(marksInput, out int marks);
        bool isTotalValid = int.TryParse(totalInput, out int total);

        if (!isMarksValid || !isTotalValid || total == 0)
        {
            System.Console.WriteLine("Invalid input! Please enter valid integers and total > 0.");
            return;
        }

        // Breakpoint 1: Before calculation
        double percentage = marks / total * 100; // <-- Issue here

        // Breakpoint 2: After calculation
        System.Console.WriteLine("Percentage: " + percentage);
    }
}
