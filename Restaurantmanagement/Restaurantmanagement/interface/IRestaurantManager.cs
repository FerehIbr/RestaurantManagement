using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantmanagement
{
    public interface IRestaurantManager
    {
        List<MenuItem> menuitems { get; set; }
        List<Orders> orders { get; set; }
        void AddOrder(MenuItem menuItem, int count);
        void RemoveOrder(int no);
        List<Orders> GetOrdersByDateInterval(DateTime dateTime,DateTime dateTime1);
        List<Orders> GetOrderByDate(DateTime date);
        List<OrderItem> GetOrdersByPriceInterval(double price,double price1);
        Orders GetOrdersByNo(string No);
        void AddMenuItem(string no,string name, double price, Category category);
        void RemoveMenuItem(string No);
        void EditMenuItem(string name, double price, string no);
        List<MenuItem> MenuItemsSortByCategory(Category category);
        List<MenuItem> MenuItemsSortByPrice(double price, double price1);
        List<MenuItem> MenuItemsSearch(string Information);

    }
}
