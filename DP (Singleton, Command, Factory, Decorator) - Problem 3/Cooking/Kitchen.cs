using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Cooking
{
    //Factory Producer
    internal class Kitchen
    {
        public enum Food
        {
            Burger = 0
        }
        public static Cook CookSomething(Food something)
        {
            //our chef only cooks burger
            if (something == Food.Burger)
            {
                return new CookSpesificBurger();
            }
            else
            {
                Console.WriteLine("This food is not included in our menu!");
                return null;
            }
        }

    }
}
