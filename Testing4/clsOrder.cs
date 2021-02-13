using System;

namespace Testing4
{
    public class clsOrder
    {
        public int Id { get; internal set; }
        public string Address { get; internal set; }
        public DateTime DateDispatch { get; internal set; }
        public string ItemName { get; internal set; }
        public int ItemQuantity { get; internal set; }
        public bool Dispatched { get; internal set; }
        public bool Made { get; internal set; }
    }
}