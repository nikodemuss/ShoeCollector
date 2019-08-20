using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class CartFactory
    {
        public static UserCart createCart(int userId, int shoeId, int quantity)
        {
            return new UserCart()
            {
                UserId = userId,
                ShoeId = shoeId,
                Quantity = quantity
            };
        }
    }
}