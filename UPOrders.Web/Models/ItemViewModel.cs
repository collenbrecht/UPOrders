using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UPOrders.Web.Models
{
    public class ItemViewModel
    {
        public List<Item> Items { get; set; }
        public string Category { get; set; }
    }
}
