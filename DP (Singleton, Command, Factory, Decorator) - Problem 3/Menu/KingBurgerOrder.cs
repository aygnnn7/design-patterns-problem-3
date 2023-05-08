using DP__Singleton__Command__Factory__Decorator____Problem_3.Burgers;
using DP__Singleton__Command__Factory__Decorator____Problem_3.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Menu
{
    internal class KingBurgerOrder : IOrder
    {
        private Chef _chef;
        public KingBurgerOrder(Chef chef)
        {
            _chef = chef;
        }

        public void GiveOrder()
        {
            _chef.Cook(BurgerType.King);
        }

        public void DeclineOrder()
        {
            _chef.Decline(BurgerType.King);
        }
    }
}
