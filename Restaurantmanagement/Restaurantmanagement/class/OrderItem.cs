using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantmanagement
{
    public class OrderItem
    {
        public string MenuItem { get; set; }
        public string Count { get; set; }


        public OrderItem(string menuitem,string count)
        {
            this.Count = count;
            this.MenuItem = menuitem;
        }
    }
}
