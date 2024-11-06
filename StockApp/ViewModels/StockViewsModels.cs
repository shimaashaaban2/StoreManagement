using Microsoft.AspNetCore.Mvc.Rendering;
using StockApp.Models;

namespace StockApp.ViewModels
{
    public class StockViewsModels
    {
        public Item itemsList { get; set; }
        public Store storesList { get; set; }
        //public IList<SelectListItem> itemsList { get; set; }
        //public IList<SelectListItem> storesList { get; set; }
    }
}
