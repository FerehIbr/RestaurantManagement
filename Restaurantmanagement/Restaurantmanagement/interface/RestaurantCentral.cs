using System;
using System.Collections.Generic;
using System.Text;



namespace Restaurantmanagement
{
    class RestaurantCentral : IRestaurantManager
    {
        public List<MenuItem> menuitems { get ; set; }
        public List<Orders> orders { get ; set ; }

        public void AddMenuItem(string no, string name, double price, Category category)
        {
            throw new NotImplementedException();
        }

        public void AddOrder(MenuItem menuItem, int count)
        {
            throw new NotImplementedException();
        }

        public void EditMenuItem(string name, double price, string no)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetOrderByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetOrdersByDateInterval(DateTime dateTime, DateTime dateTime1)
        {
            throw new NotImplementedException();
        }

        public Orders GetOrdersByNo(string No)
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetOrdersByPriceInterval(double price, double price1)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> MenuItemsSearch(string Information)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> MenuItemsSortByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> MenuItemsSortByPrice(double price, double price1)
        {
            throw new NotImplementedException();
        }

        public void RemoveMenuItem(string No)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(int no)
        {
            throw new NotImplementedException();
        }
    }
}
