using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public object Price { get; set; }
        public bool StockAvailable { get; set; }
        public DateTime DatePurchased { get; set; }
    }
}