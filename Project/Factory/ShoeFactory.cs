using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class ShoeFactory
    {
        public static ShoeTable createShoe(string shoeName, int shoePrice, int shoeStock, string shoePict)
        {
            return new ShoeTable()
            {
                ShoeName = shoeName,
                ShoePrice = shoePrice,
                ShoeImage = shoePict,
                ShoeStock = shoeStock
            };
        }
    }
}