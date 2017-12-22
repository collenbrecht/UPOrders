using System;

namespace UPOrders
{
    public class Item
    {
        public Guid ItemId { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }

        public Item()
        {
            ItemId = Guid.NewGuid();
        }

        public Item(string name, double price, string description = ""):this()
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
