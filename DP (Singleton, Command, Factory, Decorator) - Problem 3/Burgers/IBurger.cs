using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Burgers
{
    public enum BurgerType
    {
        Classic = 1,
        King = 2,
        Vegeterian = 3
    }

    public interface IBurger
    {
        void Cook();
    }
}
