using FinalVers.Guns;

namespace FinalVers
{
    internal class Player
    {
        public string name;
        public int health;
        public double money;
        public Item[] inventory = new Item[10];


        public Player(string name, int hp, double mony)
        {
            this.name = name;
            this.health = hp;
            this.money = mony;
            this.inventory[0] = new Shotgun(3, 10000, "MEGA BABAH");
        }


        public void Attack(Weapon weapon)
        {
            weapon.Fire();
        }

        public void checkMoney()
        {
            Console.WriteLine($"У вас на счету {this.money} легушк");

        }

        public void checkInventory()
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    Console.WriteLine($"{i + 1}-ый предмет это {inventory[i].Name}");
                }

                else { continue; }
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
