using Microsoft.AspNetCore.Mvc;
using StockApp.Data;
using StockApp.Models;

namespace StockApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly AppDbContext _context;
        public StoreController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var model = _context.Stores.ToList();
            return View("index", model);
        }
        [HttpGet]
        public IActionResult AddStore()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddStore(Store store) 
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            _context.Stores.Add(store);
            _context.SaveChanges();
            return RedirectToAction("Index",store);
        }

        [HttpGet]
        public IActionResult EditStore(int id)
        {
            var store = _context.Stores.Find(id);

            return View(store);
        }
        [HttpPost]
        public IActionResult EditStore(Store store)
        {

            var existstore = _context.Stores.Find(store.Id);
            if (existstore != null)
            {
                existstore.Name = store.Name;
                existstore.ItemName = store.ItemName;
                existstore.ItemCount = store.ItemCount;

                _context.SaveChanges();
            }
            return RedirectToAction("Index", store);

        }
        public IActionResult DeleteStore(int id)
        {
            var store = _context.Stores.Find(id);
            _context.Stores.Remove(store);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult SelectStore()
        {
            return View();
        }
    }
}
