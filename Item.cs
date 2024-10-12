namespace FinalVers
{
    internal abstract class Item
    {
        public int ID;
        public int Price;
        public string Name;
        public string Type;

        protected Item(int id, int price, string name, string type)
        {
            ID = id;
            Price = price;
            Name = name;
            Type = type;
        }
    }
}
