using System;
using System.Collections.Generic;
using System.Text;

namespace Task23
{
    internal class Shop
    {
        List<Order> Orders = new List<Order>();
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public int GetOrdersAvg()
        {
            int sum = 0, count = 0;
            foreach (Order item in Orders)
            {
                sum += item.Price;
                count++;
            }
            return sum / count;
        }
        public List<int> GetOrderAvg(DateTime DT)
        {
            List<int> list = new List<int>();
            foreach (var item in Orders)
            {
                if (item.dateTime > DT) list.Add(item.TotalAmount);
            }
            return list;
        }
        public void RemoveOrderByNo(int no)
        {
            foreach (var item in Orders)
            {
                if (item.No == no) Orders.Remove(item);
            }
        }
        public List<Order> GetOrderByPrice(int minPrice , int maxPrice)
        {
            List<Order> orders = new List<Order>();
            foreach (var item in Orders)
            {
                if (item.Price>=minPrice &&  item.Price<=maxPrice)
                {
                    orders.Add(item);
                }
            }
            return orders;
        }
    }
}
