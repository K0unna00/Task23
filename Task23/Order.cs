using System;
using System.Collections.Generic;
using System.Text;

namespace Task23
{
    internal class Order
    {
        public Order()
        {
            _totalCount = 0;
            No = _totalCount;
            dateTime = DateTime.Now;
        }
        int _totalCount;
        public int No { get; }
        public int ProductCount;
        public int Price;
        public int TotalAmount;
        public DateTime dateTime;

    }
}
