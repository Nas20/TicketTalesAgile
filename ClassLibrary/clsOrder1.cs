using System;
using Testing4;

namespace Testing4
{
    public class clsOrder1
    {
        
        public string ItemQuantity { get; set; }
        public string ItemName { get; set; }
        public string Address { get; set; }
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateDispatch { get; set; }

        public bool Find(int orderId)
        {
            return true;
        }
    }
}
