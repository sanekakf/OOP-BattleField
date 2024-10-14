namespace FinalVers
{
    internal class Battlefield
    {
        
        public void Fight(Player player, Player enemy)
        {
            Random random = new Random();
            var weapon = player.getChosenWeapon();
            if (weapon == null)
            {
                Console.WriteLine("У вас не экипировано оружие\nВы убежали!");
            }
            else
            {
                int orel = random.Next(0, 2);
                switch (orel)
                {
                    case 0:
                        Console.WriteLine($"{player.name} наносит удар!");
                        player.Attack(weapon, enemy);
                        enemy.Attack(weapon, player);
                        Console.WriteLine($"{enemy.name} наносит ответный удар!\n");
                        break;
                        
                    case 1:
                        Console.WriteLine($"{enemy.name} атакует первым!");
                        enemy.Attack(weapon, player);
                        player.Attack(weapon, enemy);
                        Console.WriteLine($"{player.name} отвечает!\n");


                        break;
                }
                Console.WriteLine($"\bБоевая Сводка\nЗдоровье {player.name}={player.health}\nЗдоровье {enemy.name}={enemy.health}");


            }

        }

        public void findBattle(Player player)
        {
            Shop shop = new Shop();
            Random random = new Random();
            Player enemy = new("akexx", random.Next(50,350),0,random.Next(50,600));
            enemy.addToInventory(shop.assortment[random.Next(0, shop.assortment.Length)]);
            enemy.setWeapon((Weapon)enemy.inventory[0]);
            Console.WriteLine($"...\nВы находите Врага!" +
                $"\n{enemy.name}\n" +
                $"У него в руках {enemy.inventory[0].Name}({enemy.inventory[0].Type})\n" +
                $"{enemy.armor} брони\n" +
                $"{enemy.health} здоровья"
                );
            Console.Write("\n1)Бой\n2)Бежать\n3)Выйти в главное меню\nДраться? ");
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
