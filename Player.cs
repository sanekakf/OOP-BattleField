using FinalVers.Guns;
using GameeE;

namespace FinalVers
{
    internal class Player(string name, int hp, double mony, int armor = 0)
    {
        public string name = name;
        public int health = hp;
        public double money = mony;
        public Item[] inventory = new Item[10];
        public int armor = armor;
        protected Weapon chosenWeapon = null;

        public void Attack(Weapon weapon, Player enemy)
        {

            int totalDamage=weapon.Damage;
            enemy.health = enemy.health - totalDamage;
            Console.WriteLine($"{this.name} аттаковал {enemy.name} на {totalDamage}");
        }

        public void checkMoney()
        {
            Console.WriteLine($"У вас на счету {this.money} легушк");

        }

        public Weapon getChosenWeapon()
        {
            if (this.chosenWeapon == null) { return null; }
            else
            {
                return chosenWeapon;

            }
        }

        public void setWeapon(Weapon weapon)
        {
            this.chosenWeapon = weapon;
        }

        public void checkInventory()
        {
            int c = 0;
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    Console.WriteLine($"{i + 1}-ый предмет это {inventory[i].Name}");
                }
                else if (inventory[i] == null)
                {
                    c++;
                    if (c == 10)
                    {
                        Console.WriteLine("У вас пустой инвентарь");
                    }

                }

                

                else { continue; }
            }
            if (c!= 10)
            {
                Console.Write("\nВыберите своё оружие: ");
                int answ = Convert.ToInt32(Console.ReadLine());
                this.chosenWeapon = (Weapon)inventory[answ-1];
                Console.WriteLine($"Вы выбрали {this.chosenWeapon.Name}({this.chosenWeapon.Type})");
            }
            

        }
        public void addToInventory(Item item)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    this.inventory[i] = item;
                    break;
                }
            }


        }

        public void useItem(Item item)
        {
            if (inventory.Contains(item))
            {
                if (item.GetType() == typeof(Food))
                {
                    var food = (Food)item;
                    this.health += food.HealingPoints;
                    Console.WriteLine($"{this.name} использовал предмет {food.Name} и восполнил здоровье на {food.HealingPoints}");
                }
                else
                {
                    Console.WriteLine("Данный предмет не является едой или зельем");
                }
            }
            else
            {
                Console.WriteLine("У вас нет этого предмета в инветаре!");
            }
        }

    }
}
