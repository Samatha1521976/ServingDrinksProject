using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServingDrinksProject
{
   
        // Mojito class implementing IPrice
       internal class Mojito : IPrice
        {
            private const int _sodaQuantity = 4;
            private const int _alcoholQuantity = 2;

            public double CalculatePrice(int quantity)
            {
                Ingredient ingredient = new Ingredient(_sodaQuantity, _alcoholQuantity);
                return ingredient.CalculatePrice(quantity);
            }
        }
    
}
