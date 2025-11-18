// See https://aka.ms/new-console-template for more information

namespace Task_4;

class Program
{
    static void Main()
    {
        // Object using default constructor
        Player defaultPlayer = new Player();
        System.Console.WriteLine("Default Player values:");
        System.Console.WriteLine("Name: " + defaultPlayer.playerName);
        System.Console.WriteLine("Level: " + defaultPlayer.level);
        System.Console.WriteLine("Health: " + defaultPlayer.health);
        System.Console.WriteLine();

        // Object using parameterized constructor
        Player paramPlayer = new Player("Madhav", 5, 100);
        System.Console.WriteLine("Parameterized Player values:");
        System.Console.WriteLine("Name: " + paramPlayer.playerName);
        System.Console.WriteLine("Level: " + paramPlayer.level);
        System.Console.WriteLine("Health: " + paramPlayer.health);
    }
}
