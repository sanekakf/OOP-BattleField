namespace FinalVers
{
    internal abstract class Item
    {
        private int ID;
        public readonly int Price;
        public readonly string Name;
        public readonly string Type;

        protected Item(int id, int price, string name, string type)
        {
            ID = id;
            Price = price;
            Name = name;
            Type = type;
        }
        protected int GetId() 
        {
            return ID;
        }
        
    }
}
