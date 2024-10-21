using System;
using System.Numerics;

namespace FinalVers
{
    internal class Battlefield
    {

        public static void DrawHp(int hp, ConsoleColor color)
        {
            int minihp=0;
            if (hp < 10)
            {
                minihp = 1;
            }
            else if (hp >= 10 && hp < 20)
            {
                minihp = 2;
            }
            else if (hp >= 20 && hp < 30)
            {
                minihp = 3;
            }
            else if (hp >= 30 && hp < 40)
            {
                minihp = 4;
            }
            else if (hp >= 40 && hp < 50)
            {
                minihp = 5;
            }
            else if (hp >= 50 && hp < 60)
            {
                minihp = 6;
            }
            else if (hp >= 60 && hp < 70)
            {
                minihp = 7;
            }
            else if (hp >= 70 && hp < 80)
            {
                minihp = 8;
            }
            else if (hp >= 80 && hp < 90)
            {
                minihp = 9;
            }
            else if (hp >= 90 )
            {
                minihp = 10;
            }
            ConsoleColor defColour = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < minihp; i++)
            {
                bar += " ";

            }
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defColour;

            for (int i = hp; i < 10; i++)
            {
                bar += " ";
            }
            Console.Write(']');

        }

        public void midFight(Player player, Player enemy)
        {
            Console.Write("\nВы хотите продолжить битву?\n" +
                    "1)Продолжить\n" +
                    "2)Бежать с поле боя\n" +
                    "3)Использовать инвентарь\n" +
                    "Введите цифру: ");
            int next = Convert.ToInt32(Console.ReadLine());
            switch (next)
            {
                case 1:
                    Fight(player, enemy); break;
                case 2:
                    Menu.start(player); break;
                case 3:
                    Console.WriteLine("\nВаш инвентарь:");
                    Item[] inventory = player.inventory;
                    for (int i = 0; i<inventory.Length; i++)
                    {
                        if (inventory[i] != null)
                        {
                            Console.WriteLine($"{i + 1}) {inventory[i].Name}[{inventory[i].Type}]");
                        }
                        else
                        {
                            continue;
                        }
                    }
                    midFight(player, enemy);
                    break;
            }
        }


        public void Fight(Player player, Player enemy)
        {
            Console.Clear();
            Random random = new Random();
            var weapon = player.getChosenWeapon();
            var enemyWeapon = enemy.getChosenWeapon();
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
                        enemy.Attack(enemyWeapon, player);
                        Console.WriteLine($"{enemy.name} наносит ответный удар!\n");
                        break;
                        
                    case 1:
                        Console.WriteLine($"{enemy.name} атакует первым!");
                        enemy.Attack(weapon, player);
                        player.Attack(enemyWeapon, enemy);
                        Console.WriteLine($"{player.name} отвечает!\n");


                        break;
                }
                Console.WriteLine("{Боевая Сводка}\n");
                Console.Write($"Здоровье {player.name}={player.health}");
                DrawHp(player.health, ConsoleColor.Green);
                Console.WriteLine($"\nЗдоровье {enemy.name}={enemy.health}");
                DrawHp(enemy.health, ConsoleColor.Red);
                if (player.health <= 0)
                {
                    Console.WriteLine("Вы проиграли!...");
                    Console.ReadKey();
                    player.health = 100;
                    Menu.start(player);
                }
                else if (enemy.health <= 0) 
                {
                    Console.WriteLine("ПОБЕДА!...");
                    player.money += random.Next(50,300);
                    player.health += 15;
                    Console.ReadKey();
                    findBattle(player);
                }
                midFight(player, enemy);
                

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
            Console.Write("\n1)Бой\n2)Бежать\nДраться? ");
            int answ = Convert.ToInt32(Console.ReadLine());
            switch (answ)
            {
                case 1:
                    Fight(player, enemy); break;
                case 2:
                    Menu.start(player); break;
            }

        }


    }
}
