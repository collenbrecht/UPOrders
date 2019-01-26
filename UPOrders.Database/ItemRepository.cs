using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPOrders.Database
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> Items {
            get
            {
                return _appDbContext.Items;
            }
        }

        public Item GetById(Guid id)
        {
            return _appDbContext.Items.FirstOrDefault(i => i.ItemId == id);
        }
    }
}
