using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantmanagement
{
    public class OrderItem
    {
        public string MenuItem { get; set; }
        public int Count { get; set; }


        public OrderItem(string menuitem,int count)
        {
            this.Count = count;
            this.MenuItem = menuitem;
        }
    }
}
