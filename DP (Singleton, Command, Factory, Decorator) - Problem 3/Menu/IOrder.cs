using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Menu
{
    public interface IOrder
    {
        void GiveOrder();
        void DeclineOrder();
    }
}
