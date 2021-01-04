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


            MenuItem menuitem5 = new MenuItem("SO100", "Vegetablesoup", 5, Category.soup);
            MenuItem menuitem6 = new MenuItem("SO101", "Tomatosoup", 5, Category.soup);
            MenuItem menuitem7 = new MenuItem("SO102", "Chickencream", 5, Category.soup);
            MenuItem menuitem8 = new MenuItem("SO103", "Mushroom",5, Category.soup);


            MenuItem menuitem9 = new MenuItem("DR100", "Amazon",9,Category.drink);
            MenuItem menuitem10 = new MenuItem("DR101", "Electric Sun Rise",9, Category.drink);
            MenuItem menuitem11 = new MenuItem("DR102", "Fresh Juice",7, Category.drink);
            MenuItem menuitem12 = new MenuItem("DR103", "Lemonade",6, Category.drink);

            MenuItem menuitem13 = new MenuItem("DS100", "Malaga", 9, Category.desert);
            MenuItem menuitem14 = new MenuItem("DS101", "New york cheesecake",7, Category.desert);
            MenuItem menuitem15 = new MenuItem("DS102", "Raspberry cheesecake",8 , Category.desert);
            MenuItem menuitem16 = new MenuItem("DS103", "Tiramisu",8, Category.desert);


            Console.WriteLine($"{menuitem1.No}-{menuitem1.Name}-{menuitem1.Price}-{menuitem1.Category}");
            Console.WriteLine($"{menuitem2.No}-{menuitem2.Name}-{menuitem2.Price}-{menuitem2.Category}");
            Console.WriteLine($"{menuitem3.No}-{menuitem3.Name}-{menuitem3.Price}-{menuitem3.Category}");
            Console.WriteLine($"{menuitem4.No}-{menuitem4.Name}-{menuitem4.Price}-{menuitem4.Category}");


            Console.WriteLine($"{menuitem5.No}-{menuitem5.Name}-{menuitem5.Price}-{menuitem5.Category}");
            Console.WriteLine($"{menuitem6.No}-{menuitem6.Name}-{menuitem6.Price}-{menuitem6.Category}");
            Console.WriteLine($"{menuitem7.No}-{menuitem7.Name}-{menuitem7.Price}-{menuitem7.Category}");
            Console.WriteLine($"{menuitem8.No}-{menuitem8.Name}-{menuitem8.Price}-{menuitem8.Category}");

            Console.WriteLine($"{menuitem9.No}-{menuitem9.Name}-{menuitem9.Price}-{menuitem9.Category}");
            Console.WriteLine($"{menuitem10.No}-{menuitem10.Name}-{menuitem10.Price}-{menuitem10.Category}");
            Console.WriteLine($"{menuitem11.No}-{menuitem11.Name}-{menuitem11.Price}-{menuitem11.Category}");
            Console.WriteLine($"{menuitem12.No}-{menuitem12.Name}-{menuitem12.Price}-{menuitem12.Category}");


            Console.WriteLine($"{menuitem13.No}-{menuitem13.Name}-{menuitem13.Price}-{menuitem13.Category}");
            Console.WriteLine($"{menuitem14.No}-{menuitem14.Name}-{menuitem14.Price}-{menuitem14.Category}");
            Console.WriteLine($"{menuitem15.No}-{menuitem15.Name}-{menuitem15.Price}-{menuitem15.Category}");
            Console.WriteLine($"{menuitem16.No}-{menuitem16.Name}-{menuitem16.Price}-{menuitem16.Category}");


            




        }
    }
}
