namespace FinalVers
{
    internal class Intro
    {
        public static void start(Player player)
        {
            Shop shop = new();
            Battlefield battlefield = new();
            Console.Clear();
            Console.WriteLine("\nЧто вы хотите сделать?\n1)Посмотреть свой инвентарь\n2)Посмотреть свой баланс\n3)Зайти в магазин\n4)Пойти в бой\n");
            Console.Write("Введите цифру: ");
            int useransw = Convert.ToInt32(Console.ReadLine());
            switch (useransw)
            {
                case 1:
                    player.checkInventory();
                    break;
                case 2:
                    player.checkMoney();
                    break;
                case 3:
                    shop.enterShop(player);
                    break;
                case 4:
                    battlefield.findBattle(player);
                    break;
            }
            Console.ReadKey();
            start(player);
        }

    }
}
