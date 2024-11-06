using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using StockApp.IRepository.ItemRepo;

namespace StockApp.Repository.Item
{
    public class ItemRepo : IItemRepo
    {
        private readonly AppDbContext _context;
        public ItemRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Models.Item> GetItems(int id)
        {
            SqlParameter itemId = new SqlParameter("@id", System.Data.SqlDbType.Int);
            itemId.Value = (object)id ?? DBNull.Value;
            return _context.Items.FromSqlRaw("Execute SelectItems @id", itemId).ToList();
        
       }

    }
}
