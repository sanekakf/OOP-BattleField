namespace FinalVers
{
    abstract class Weapon : Item
    {
        public int Damage;
        protected Weapon(int id, int price, string name, string type, int damage) : base(id, price, name, type)
        {
            Damage = damage;
        }

    }
}
