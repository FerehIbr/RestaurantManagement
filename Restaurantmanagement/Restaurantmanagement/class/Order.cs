using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantmanagement
{
    public class Orders
    {
        public int No { get; set; }
        public string OrderItem { get; set; }
        public double TotalAmount { get; set; }
        public string Date { get; set; }
        public object OrderItems { get; internal set; }
    }
}
