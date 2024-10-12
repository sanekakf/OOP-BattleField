using FinalVers;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player("Alex", 100, 500);
        Shop shop = new Shop();
        Intro starter = new Intro();
        starter.start(player, shop);


    }
}