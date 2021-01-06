using System;
using System.Collections.Generic;
using System.Text;



namespace Restaurantmanagement
{
    class RestaurantCentral : IRestaurantManager
    {
        public List<MenuItem> menuitems { get; set; }
        public List<Orders> orders { get; set; }

        public void AddMenuItem(string no,string name, double price, Category category)
        {
            MenuItem menuitem = new MenuItem(no,name, price, category);
            this.menuitems.Add(menuitem);
        }

        public void AddOrder(string menuItem, string count)
        {
            OrderItem orderItem = new OrderItem(menuItem, count);
            Orders orders = new Orders();
            orders.OrderItems.Add(orderItem);
            this.orders.Add(orders);
           

        }

        public void EditMenuItem(string name, double price, string no)
        {
            foreach ( var c in menuitems)
            {
                if()
                {

                }
            }
        }

        public List<Orders> GetOrderByDate(DateTime date)
        {
            List<Orders> newList = new List<Orders>();
        }

        public List<Orders> GetOrdersByDateInterval(DateTime dateTime, DateTime dateTime1)
        {
            List<Orders> newList = new List<Orders>();
        }

        public Orders GetOrdersByNo(string No)
        {
            Orders orders = new Orders();
        }

        public List<OrderItem> GetOrdersByPriceInterval(double price, double price1)
        {
            List<OrdersItem> newList = new List<OrdersItem>();
            foreach (var item in this.orders)
            {

            }
        }

        public List<MenuItem> MenuItemsSearch(string Information)
        {
            
        }

        public List<MenuItem> MenuItemsSortByCategory(Category category)
        {
            
        }

        public  List<MenuItem> MenuItemsSortByPrice(double price, double price1)
        {
            
        }

        public void RemoveMenuItem(string No)
        {
            
        }

        public void RemoveOrder(int no)
        {
            throw new NotImplementedException();
        }
    }
}
