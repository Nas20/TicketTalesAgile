using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisOrder = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public clsStock ThisStock { get; set; }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }

            set
            {
                //We will worry about this later;
            }
        }
    }
}
