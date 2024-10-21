namespace FinalVers
{
    abstract class Weapon : Item
    {
        public int Damage;
        protected Weapon(int id, int price, string name, string type, int damage, bool useable=false) : base(id, price, name, type, useable)
        {
            Damage = damage;
        }

    }
}
