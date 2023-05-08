using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Saucing
{
    public class BurgerSaucer : FoodSaucer
    {
        public enum Sauce
        {
            Garlic = 1,
            Ketchup = 2
        }
        private Sauce sauce;
        public BurgerSaucer(ISauce saucedBurger, Sauce sauce) : base(saucedBurger)
        {
            this.sauce = sauce;

        }

        override
        public void Sauced()
        {
            PutSauce();
            base.Sauced();
        }

        public void PutSauce()
        {
            //Chef.ReadyBurger.Sa
            Console.WriteLine($"Cheff is adding some {sauce}...");
        }

    }
}
