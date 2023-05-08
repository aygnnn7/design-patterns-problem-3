using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3
{
    public class Restaurant
    {
        private static Restaurant restaurant;
        private Restaurant() { }

        public static Restaurant getRestaurant()
        {
            if (restaurant == null)
            {
                restaurant = new Restaurant();
            }
            return restaurant;
        }

        public void Open()
        {
            Console.WriteLine("The restaurant is open.");
            Console.WriteLine();
        }
        public void Close()
        {
            Console.WriteLine();
            Console.WriteLine("The restaurant is closed."); ;
        }
    }
}
