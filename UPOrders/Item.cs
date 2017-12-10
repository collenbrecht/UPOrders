using System;

namespace UPOrders
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
