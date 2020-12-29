using System;
namespace Restaurantmanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem menuitem1 = new MenuItem("PI100","VegettarianPizza", 12,Category.mainfood);
            MenuItem menuitem2 = new MenuItem("PI101", "MiksPizza", 19, Category.mainfood);
            MenuItem menuitem3 = new MenuItem("PI102", "PepperoniPizza", 12, Category.mainfood);
            MenuItem menuitem4 = new MenuItem("PI103", "RobesPierPizza", 18, Category.mainfood);
           

            Console.WriteLine($"{menuitem1.No}-{menuitem1.Name}-{menuitem1.Price}-{menuitem1.Category}");
            Console.WriteLine($"{menuitem2.No}-{menuitem2.Name}-{menuitem2.Price}-{menuitem2.Category}");
            Console.WriteLine($"{menuitem3.No}-{menuitem3.Name}-{menuitem3.Price}-{menuitem3.Category}");
            Console.WriteLine($"{menuitem4.No}-{menuitem4.Name}-{menuitem4.Price}-{menuitem4.Category}");



        }
    }
}
