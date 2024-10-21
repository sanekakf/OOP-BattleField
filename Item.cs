namespace FinalVers
{
    internal abstract class Item
    {
        private int ID;
        public readonly int Price;
        public readonly string Name;
        public readonly string Type;
        public readonly bool Useable;

        protected Item(int id, int price, string name, string type, bool useable)
        {
            ID = id;
            Price = price;
            Name = name;
            Type = type;
            Useable = useable;
        }
        protected int GetId() 
        {
            return ID;
        }
        
    }
}
