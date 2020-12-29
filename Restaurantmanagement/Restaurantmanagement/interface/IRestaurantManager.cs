using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantmanagement
{
    public interface IRestaurantManager
    {
        List<MenuItem> menuitems { get; set; }
        List<Orders> orders { get; set; }
        void AddOrder(Orders orders);
        

    }
}
