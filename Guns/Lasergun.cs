namespace FinalVers.Guns
{
    internal class Lasergun(int id, int price, string name, int damage=40, string type = "Lasergun") : Weapon(id, price, name, type, damage)
    {
        public readonly int damage = damage;
        
    }
}
