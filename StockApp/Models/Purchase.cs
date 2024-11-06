namespace StockApp.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public string ItemName { get; set; }
        public string StoreName { get; set; }
        public int price { get; set; }      
        public int count { get; set; }      

    }
}
