namespace FinalVers
{
    internal class Battlefield
    {
        
        public void Fight(Player player, Player enemy)
        {
            if (player.getChosenWeapon == null)
            {
                Console.WriteLine(player.getChosenWeapon());
                Console.WriteLine("У вас не экипировано оружие");
            }
            else
            {
                Console.WriteLine(player.getChosenWeapon());
                Console.WriteLine($"{player.name} наносит удар!");

            }

        }

        public void findBattle(Player player)
        {
            Shop shop = new Shop();
            Random random = new Random();
            Player enemy = new("akexx", random.Next(50,350),0,random.Next(50,600));
            enemy.addToInventory(shop.assortment[random.Next(0, shop.assortment.Length)]);
            enemy.setWeapon(enemy.inventory[0]);
            Console.WriteLine($"...\nВы находите Врага!" +
                $"\n{enemy.name}\n" +
                $"У него в руках {enemy.inventory[0].Name}({enemy.inventory[0].Type})\n" +
                $"{enemy.armor} брони\n" +
                $"{enemy.health} здоровья"
                );
            Console.Write("\n1)Бой\n2)Бежать\n3)Выйти в главное меню\nДраться?");
            int answ = Convert.ToInt32(Console.ReadLine());
            switch (answ)
            {
                case 1:
                    Fight(player, enemy); break;
                case 2:
                    findBattle(player); break;
                case 3:
                    Intro.start(player); break;
            }

        }


    }
}
