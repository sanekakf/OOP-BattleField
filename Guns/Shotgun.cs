namespace FinalVers.Guns
{
    internal class Shotgun(int id, int price, string name, int damage = 20, string type = "Shotgun") : Weapon(id, price, name, type, damage)
    {
        public readonly int damage = damage;

        
    }
}
