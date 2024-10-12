namespace FinalVers.Guns
{
    internal class Lasergun(int id, int price, string name, string type = "Lasergun") : Weapon(id, price, name, type)
    {
        public string name = name;
        public string type = type;
        public override void Fire()
        {
            Console.WriteLine(name);
            Console.WriteLine("Плиу плиу");
        }
    }
}
