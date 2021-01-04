using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantmanagement
{
    class RestaurantCentral : IRestaurantManager
    {
        public List<MenuItem> menuitems { get; set; }
        public List<Orders> orders { get; set ; }
        public List<OrderItem> orderItems { get; set; }
        List<MenuItem> IRestaurantManager.menuitems { get; set; }
        List<Orders > Orders { get; set; }

        public void AddMenuItem(string name, double price, Category category)
        {
            
        }

        public void AddOrder(MenuItem menuItem, int count)
        {
            
        }

        public void EditMenuItem(string name, double price, string no)
        {
            
        }

        public List<Orders> GetOrdersByDate(DateTime date) 
        {
            
        }

        public Orders GetOrdersByNo(string No)
        {
            
        }

        public List<Orders> GetOrdersByDateInterval(DateTime dateTime, DateTime dateTime1)
        {
            
        }

        public List<OrderItem> GetOrdersByPriceInterval(double price, double price1)
        {
            
        }

        public List<MenuItem> MenuItemsSearch(string Information)
        {
            
        }

        public List<MenuItem> MenuItemsSortByCategory(Category category)
        {
            
        }

        public List<MenuItem> MenuItemsSortByPrice(double price, double price1)
        {
            
        }

        public void RemoveMenuItem(string No)
        {
           
        }

        public void RemoveOrder(int no)
        {
            
        }

        public List<Orders> GetOrderByDate(DateTime date)
        {
            
        }
    }
}
