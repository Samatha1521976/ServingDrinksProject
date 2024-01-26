using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServingDrinksProject
{
    internal class Ingredient
    {
        // Ingredient class implementing IPrice
            private const double sodaPrice = 15;
            private const double alcoholPrice = 500;

            private readonly int _sodaQuantity;
            private readonly int _alcoholQuantity;

            public Ingredient(int sodaQuantity, int alcoholQuantity)
            {
                _sodaQuantity = sodaQuantity;
                _alcoholQuantity = alcoholQuantity;
            }

            public double CalculatePrice(int quantity)
            {
                return (sodaPrice * _sodaQuantity + alcoholPrice * _alcoholQuantity) * quantity;
            }

            public double IngredientsAmount()
            {
                return sodaPrice * _sodaQuantity + alcoholPrice * _alcoholQuantity;
            }
        
    }
}
