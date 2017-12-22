using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UPOrders.Database;
using UPOrders.Web.Models;

namespace UPOrders.Web.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ViewResult List()
        {
            ItemViewModel itemViewModel = new ItemViewModel();
            itemViewModel.Items = _itemRepository.Items.ToList();
            itemViewModel.Category = "Broodjes";
            return View(itemViewModel);
        }
    }
}