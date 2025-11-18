// See https://aka.ms/new-console-template for more information

namespace Task_3;

class Program
{
    static void Main()
    {
        ParameterDemo demo = new ParameterDemo();

        // Ref example
        int myNumber = 5;
        System.Console.WriteLine("Original number: " + myNumber);
        demo.Increase(ref myNumber);
        System.Console.WriteLine("After Increase(ref): " + myNumber);
        System.Console.WriteLine();

        // Out example
        demo.GetFullName(out string fullName);
        System.Console.WriteLine("Full Name from GetFullName(out): " + fullName);
        System.Console.WriteLine();

        // Params example
        int sum = demo.SumAll(1, 2, 3, 4, 5);
        System.Console.WriteLine("Sum from SumAll(params): " + sum);
    }
}
