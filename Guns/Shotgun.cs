namespace FinalVers.Guns
{
    internal class Shotgun(int id, int price, string name, string type = "Shotgun") : Weapon(id, price, name, type)
    {
        public string name = name;
        public string type = type;

        public override void Fire()
        {
            Console.WriteLine("PLAfFFFffFFth");
        }
    }
}
