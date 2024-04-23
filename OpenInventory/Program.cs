internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your username: ");
        string name = Console.ReadLine();

        Console.Write("Enter your password: ");
        string pass = Console.ReadLine();

        Console.WriteLine("========================================");
        Console.WriteLine("Welcome To OpenInventory Version 1.0.0");
        Console.WriteLine("Logged in as " + name);
        Console.WriteLine("========================================");
    }
}