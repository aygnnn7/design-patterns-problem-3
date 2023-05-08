using DP__Singleton__Command__Factory__Decorator____Problem_3.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Staff
{
    public class Cashier
    {
        private IOrder order;

        public void setOrder(IOrder order)
        {
            this.order = order;
        }

        public void TellChefOrder()
        {
            if (this.order == null)
            {
                Console.WriteLine("No оrder to tell");
                return;
            }
            this.order.GiveOrder();
        }

        public void TellChefDecline()
        {
            if (this.order == null)
            {
                Console.WriteLine("No order to decline");
                return;
            }
            this.order.DeclineOrder();
        }
    }
}
