using DP__Singleton__Command__Factory__Decorator____Problem_3.Saucing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__Singleton__Command__Factory__Decorator____Problem_3.Burgers
{
    internal class KingBurger : IBurger, ISauce
    {

        public void Cook()
        {
            Console.WriteLine("The cheff cooked a king burger.");
        }
        public void Sauced()
        {
            Console.WriteLine($"He putted the sauce on it.");
        }
    }
}
