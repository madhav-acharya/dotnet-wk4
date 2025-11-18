// See https://aka.ms/new-console-template for more information
using Task_2;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Call the void method
        calc.PrintWelcome();

        // Call Add method and print result
        int sum = calc.Add(5, 10);
        Console.WriteLine($"Sum: {sum}");

        // Call Multiply with both parameters
        int product1 = calc.Multiply(5, 3);
        Console.WriteLine($"Product (5*3): {product1}");

        // Call Multiply with only one parameter (num2 defaults to 1)
        int product2 = calc.Multiply(7);
        Console.WriteLine($"Product (7*1 default): {product2}");
    }
}