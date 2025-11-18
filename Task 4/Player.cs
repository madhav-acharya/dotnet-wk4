namespace Task_4;

public class Player
{
    public string playerName;
    public int level;
    public int health;

    // Default constructor
    public Player()
    {
        System.Console.WriteLine("Default constructor has been called");
    }

    // Parameterized constructor
    public Player(string playerName, int level, int health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }
}