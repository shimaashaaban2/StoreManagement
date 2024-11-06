using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StockApp.Data;
using StockApp.DTO;
using StockApp.IRepository.ItemRepo;
using StockApp.Models;
using System.Diagnostics.Metrics;

namespace StockApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext _context;
         private readonly IItemRepo _itemRepo;
        public ItemController(AppDbContext context)  /*IItemRepo itemRepo*/
        {
            _context = context;
           // _itemRepo = itemRepo;
        }
        public IActionResult Index()
        {
           var model= _context.Items.ToList();
            return View("index", model);
        }
        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddItem(Item item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                _context.Items.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index", item);
                
            }
            catch(Exception ex) 
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(ex.Message);
            }
           
        }
        [HttpGet]
        public IActionResult EditItem(int id)
        {
            var item = _context.Items.Find(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult EditItem(Item item)
        {
            var existitem = _context.Items.Find(item.Id);
            if (existitem != null)
            {
                existitem.Name = item.Name;
                existitem.Quantity = item.Quantity;
              
                _context.SaveChanges();
            }
            return RedirectToAction("Index", item);
          
        }
        public IActionResult DeleteItem(int id)
        {

            var item = _context.Items.Find(id);
           _context.Items.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
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

        //public IActionResult getItems(Item item)
        //{
        //    var items = _context.Items.Find(item.Id);
        //    if (items != null) 
        //    {
        //        items.Name.ToList();
        //    }
        //    return View(items);
        //}
    }
}
