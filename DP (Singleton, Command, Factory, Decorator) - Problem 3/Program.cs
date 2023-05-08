using DP__Singleton__Command__Factory__Decorator____Problem_3.Menu;
using DP__Singleton__Command__Factory__Decorator____Problem_3.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region initializing
            Restaurant restaurant = Restaurant.getRestaurant();
            Chef chef = new Chef();
            Cashier cashier = new Cashier();

            ClassicBurgerOrder classicBurger = new ClassicBurgerOrder(chef);
            VegeterianBurgerOrder vegeterianBurger = new VegeterianBurgerOrder(chef);
            KingBurgerOrder kingBurger = new KingBurgerOrder(chef);
            #endregion

            #region cashier tells the orders to the chef, and he cooks them
            restaurant.Open();

            //let's give some order as a customer
            cashier.setOrder(classicBurger);
            cashier.TellChefOrder();
            Thread.Sleep(2);
            chef.GiveReadyBurgerToCashier();

            //second order
            cashier.setOrder(vegeterianBurger);
            cashier.TellChefOrder();
            Thread.Sleep(2);
            chef.GiveReadyBurgerToCashier();

            //another order
            cashier.setOrder(kingBurger);
            cashier.TellChefOrder();
            Thread.Sleep(10);

            //I changed my mind. Cheff won`t be happy for sure
            cashier.TellChefDecline();
            chef.GiveReadyBurgerToCashier();

            restaurant.Close();
            #endregion


            Console.Read();
        }
    }
}
