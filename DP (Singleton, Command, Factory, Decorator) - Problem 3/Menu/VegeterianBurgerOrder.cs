using DP__Singleton__Command__Factory__Decorator____Problem_3.Burgers;
using DP__Singleton__Command__Factory__Decorator____Problem_3.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Menu
{
    internal class VegeterianBurgerOrder : IOrder
    {
        private Chef _chef;
        public VegeterianBurgerOrder(Chef chef)
        {
            _chef = chef;
        }

        public void GiveOrder()
        {
            _chef.Cook(BurgerType.Vegeterian);
        }

        public void DeclineOrder()
        {
            _chef.Decline(BurgerType.Vegeterian);
        }
    }
}
