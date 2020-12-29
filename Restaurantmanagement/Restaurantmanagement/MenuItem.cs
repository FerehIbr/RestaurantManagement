using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantmanagement
{
    public class MenuItem
    {
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public MenuItem (int no,string name,double price,Category category)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
            this.Category = category;

        }

    }
}
