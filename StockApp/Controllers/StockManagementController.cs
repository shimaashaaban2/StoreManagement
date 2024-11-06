using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using StockApp.IRepository.ItemRepo;
using StockApp.Models;

namespace StockApp.Controllers
{
    public class StockManagementController : Controller
    {
        private readonly AppDbContext _context;
       // private readonly IItemRepo _itemRepo;
        public StockManagementController(AppDbContext context)  /*IItemRepo itemRepo*/
        {
            _context = context;
            // _itemRepo = itemRepo;
        }
        //public void SelectItem()
        //{
        //    IEnumerable<SelectListItem> items = _context.Items.Select(i => new SelectListItem
        //    {
        //        Text = i.Name,
        //        Value = i.Id.ToString(),

        //    });
        //    ViewBag.Items = items;
        //}
        //[HttpGet]
        //public IActionResult getItems(int id)
        //{
        //    var model = _context.Items.ToList();
        //    var items = _context.Items.OrderBy(i => i.Name).ToList();
        //    return new JsonResult(items);
        //}
        public IActionResult Index()
        {
           // model.Name = _context.Items.OrderBy(m => m.Name).ToList();
            var storageItems = _context.Purchases.ToList();
            return View(storageItems);
            // return PartialView("~/Views/Shared/_ItemList.cshtml", model);
           // return View();
           
        }
        [HttpGet]
        public IActionResult Getitems()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Getitems(Purchase purchase)
        {
            _context.Purchases.Add(purchase);
            _context.SaveChanges();
            return RedirectToAction("index",purchase);
        }
        [HttpGet]
        public IActionResult changeItems(int id)
        {
            var item = _context.Purchases.Find(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult changeItems(Purchase purchase)
        {

            var existitem = _context.Purchases.Find(purchase.Id);
            if (existitem != null)
            {
                existitem.ItemName = purchase.ItemName;
                existitem.StoreName = purchase.StoreName;
                existitem.price = purchase.price;
                existitem.count = purchase.count;

                _context.SaveChanges();
            }
            return RedirectToAction("Index", purchase);
        }
        

        public JsonResult SelectItems(int id)
        {
            var itm = _context.Items.ToList();
            return new JsonResult(itm);
        }
         public JsonResult SelectStores(int id)
        {
            var stor = _context.Stores.ToList();
            return new JsonResult(stor);
        }


    }
}
