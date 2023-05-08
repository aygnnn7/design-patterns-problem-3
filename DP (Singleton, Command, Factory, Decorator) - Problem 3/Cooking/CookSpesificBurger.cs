using DP__Singleton__Command__Factory__Decorator____Problem_3.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Cooking
{
    //Concrete Factory
    internal class CookSpesificBurger : Cook
    {
        public override IBurger CookBurger(BurgerType type)
        {

            switch (type)
            {
                case BurgerType.Classic:
                    return new ClassicBurger();

                case BurgerType.King:
                    return new KingBurger();

                case BurgerType.Vegeterian:
                    return new VegetarianBurger();
                default: return null;
            }

        }
    }
}
