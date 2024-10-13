using FinalVers.Guns;

namespace FinalVers
{
    internal class Shop
    {
        
        public int i;
        public readonly Item[] assortment = [ 
            new Lasergun(1, 150, "Pif Paf"), 
            new Shotgun(2, 250, "Blobastic"), 
            new Bat(3, 10, "Boopalka"),
            new MegaFlist(4, 500, "Htysh")
        ];
        public int uservar;
        public void enterShop(Player player)
        {


            Console.WriteLine($"\nЧто вы желаете?(У вас на балансе {player.money} лягушек)\n" +
                $"1)Купить\n" +
                $"2)Продать\n" +
                $"3)назад"
            );
            Console.Write("Введите цифру: ");
            uservar = Convert.ToInt32(Console.ReadLine());
            if (uservar == 1)
            {
                Console.WriteLine("\nАссортимент:");
                for (i = 0; i < this.assortment.Length && assortment[i] != null; i++)
                {
                    if (this.assortment[i] != null) { Console.WriteLine($"{i + 1}) {assortment[i].Name}({assortment[i].Type})[{assortment[i].Price} лягушк]"); }
                }
                Console.WriteLine($"\nЖелаете ли вы что нибудь купить? ({i + 1} - что бы выйти)");
                Console.Write("Введите цифру: ");
                int userbuy = Convert.ToInt32(Console.ReadLine());
                if (userbuy < i + 1)
                {
                    if (player.money >= assortment[userbuy - 1].Price)
                    {
                        player.money -= assortment[userbuy - 1].Price;
                        player.addToInventory(assortment[userbuy - 1]);
                        Console.WriteLine($"Поздравляю! Вы приобрели {assortment[userbuy - 1].Name}\nУ вас на балансе осталось {player.money} легушк\n");

                    }

                }
            }
            if (uservar == 2)
            {
                Console.WriteLine($"Что вы хотите продать?");
                for (int k = 0; k < player.inventory.Length; k++)
                {
                    if (player.inventory[k] != null)
                    {
                        Console.WriteLine($"{k + 1}) {player.inventory[k].Name}({player.inventory[k].Type})[{player.inventory[k].Price / 1.25}]");
                    }
                    else { continue; }
                }
                Console.Write("Введите цифру: ");
                int answ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(player.inventory[answ]);
                Console.WriteLine(player.inventory[answ - 1]);
                if (player.inventory[answ - 1] != null)
                {
                    Console.WriteLine($"Вы успешно продали {player.inventory[answ - 1].Name}({player.inventory[answ - 1].Type}) за {Convert.ToSingle(player.inventory[answ - 1].Price) / 1.25}");
                    player.money += player.inventory[answ - 1].Price / 1.25;
                    Console.WriteLine($"У вас на балансе: {player.money} лгушек");
                    player.inventory[answ - 1] = null;
                }
            }
        }

    }
}
