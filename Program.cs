using FinalVers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nДобро пожаловать в мою игру!");
        Player player = new Player("Alex", 100, 500);
        Shop shop = new Shop();
        Intro.start(player);


    }
}