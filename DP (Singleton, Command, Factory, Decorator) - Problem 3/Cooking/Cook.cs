using DP__Singleton__Command__Factory__Decorator____Problem_3.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Cooking
{
    //Abstract Factory
    public abstract class Cook
    {
        public abstract IBurger CookBurger(BurgerType type);
    }
}
