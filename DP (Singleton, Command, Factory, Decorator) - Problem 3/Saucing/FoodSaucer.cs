using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Saucing
{
    public abstract class FoodSaucer : ISauce
    {
        protected ISauce SaucedBurger;
        public FoodSaucer(ISauce saucedBurger) : base()
        {

            this.SaucedBurger = saucedBurger;
        }


        public virtual void Sauced()
        {
            this.SaucedBurger.Sauced();
        }
    }
}
