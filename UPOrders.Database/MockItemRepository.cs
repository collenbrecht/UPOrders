using System;
using System.Collections.Generic;
using System.Text;

namespace UPOrders.Database
{
    public class MockItemRepository : IItemRepository
    {
        public IEnumerable<Item> Items => new List<Item>{
            new Item("Deugeniet", 3.25, "Omelet natuur, tomaat, mayo, ui"),
            new Item("Sunshine", 3.25, "Eiersla, rucola, tomaat")
        };
    }
}
