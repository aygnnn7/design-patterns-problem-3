using DP__Singleton__Command__Factory__Decorator____Problem_3.Burgers;
using DP__Singleton__Command__Factory__Decorator____Problem_3.Cooking;
using DP__Singleton__Command__Factory__Decorator____Problem_3.Saucing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DP__Singleton__Command__Factory__Decorator____Problem_3.Cooking.Kitchen;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Staff
{
    public class Chef
    {
        private bool _preparing = false;
        private Cook cooker = Kitchen.CookSomething(Food.Burger);

        public void Cook(BurgerType orderedBurgerType)
        {
            _preparing = true;
            IBurger burger = cooker.CookBurger(orderedBurgerType);
            burger.Cook();
            //cooking..
            Thread.Sleep(2000);
            PutSauce(orderedBurgerType, RandomSauce());
        }

        public void Decline(BurgerType orderedBurger)
        {
            _preparing = false;
            Console.WriteLine("Chef stoped! Order is declined!");
        }

        public void GiveReadyBurgerToCashier()
        {
            if (_preparing)
            {
                _preparing = false;
                Console.WriteLine("The cashier took the burger gave it to the customer.");
            }
            else Console.WriteLine("Cheff is not happy about that!");

            Console.WriteLine();
        }
        public void PutSauce(BurgerType orderedBurgerType, BurgerSaucer.Sauce sauce)
        {
            ISauce saucedBurger;
            switch (orderedBurgerType)
            {
                case BurgerType.Vegeterian:
                    saucedBurger = new BurgerSaucer(new VegetarianBurger(), sauce);
                    saucedBurger.Sauced();
                    break;
                case BurgerType.Classic:
                    saucedBurger = new BurgerSaucer(new ClassicBurger(), sauce);
                    saucedBurger.Sauced();
                    break;
                case BurgerType.King:
                    saucedBurger = new BurgerSaucer(new KingBurger(), sauce);
                    saucedBurger.Sauced();
                    break;
            }
        }

        public BurgerSaucer.Sauce RandomSauce()
        {
            Random r = new Random();
            bool randomSauce = r.Next(2) == 0;
            if (randomSauce)
            {
                return BurgerSaucer.Sauce.Ketchup;
            }
            return BurgerSaucer.Sauce.Garlic;

        }
    }
}
