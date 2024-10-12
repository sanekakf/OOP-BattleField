namespace FinalVers
{
    abstract class Weapon(int id, int price, string name, string type) : Item(id, price, name, type)
    {
        public abstract void Fire();
    }
}
