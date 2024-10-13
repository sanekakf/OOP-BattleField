using FinalVers.Guns;

namespace FinalVers
{
    internal class Player(string name, int hp, double mony, int armor = 0)
    {
        public string name = name;
        public int health = hp;
        public double money = mony;
        public Item[] inventory = new Item[10];
        public int armor = armor;
        protected Item chosenWeapon = null;

        public void Attack(Weapon weapon, Player enemy)
        {


            double totalDamage=Convert.ToSingle(weapon.Damage)/100*armor;
            enemy.health = Convert.ToInt32(enemy.health - totalDamage);
            Console.WriteLine($"{this.name} аттаковал {enemy.name} на {totalDamage}");
        }

        public void checkMoney()
        {
            Console.WriteLine($"У вас на счету {this.money} легушк");

        }

        public Item getChosenWeapon()
        {
            if (this.chosenWeapon == null) { return null; }
            else
            {
                return chosenWeapon;

            }
        }

        public void setWeapon(Item weapon)
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
                this.chosenWeapon = inventory[answ-1];
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

    }
}
