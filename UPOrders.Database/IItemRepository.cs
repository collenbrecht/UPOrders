using System;
using System.Collections.Generic;
using System.Text;

namespace UPOrders.Database
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
    }
}
