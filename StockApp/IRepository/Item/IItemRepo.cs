using StockApp.Models;

namespace StockApp.IRepository.ItemRepo
{
    public interface IItemRepo
    {
        IEnumerable<Item> GetItems(int id);
        
    }
}
