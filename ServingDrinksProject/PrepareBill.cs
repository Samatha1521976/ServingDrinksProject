using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServingDrinksProject
{
    // PrepareBill class
  internal  class PrepareBill
    {
        public double CalculateDrinkPrice(Func<int, double> calculatePrice, int quantity)
        {
            return calculatePrice.Invoke(quantity);
        }
    }
}
