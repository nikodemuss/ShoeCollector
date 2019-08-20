using Project.Factory;
using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class CartController
    {
        public static void addToCart(string shoeId, int UserId, string quantity)
        {
            if (shoeId.All(char.IsDigit) && quantity.All(char.IsDigit))
            {
                int id = Int32.Parse(shoeId);
                //int userId = Int32.Parse(UserId);
                int q = Int32.Parse(quantity);
                if (checkQuantity(quantity, id) && !checkSameProduct(UserId, id))
                {
                    UserCart newCart = CartFactory.createCart(UserId, id, q);
                    CartRepository.insertCart(newCart);
                    ShoeHandler.incrementTotalSales(id);
                }
                else if (checkQuantity(quantity, id))
                {
                    CartModel cart = CartHandler.getSpecificProductUserCart(UserId, id);
                    int qty = cart.Quantity;
                    qty += q;
                    CartRepository.updateCart(cart.CartId, cart.UserId, cart.ShoeId, qty);
                }
            }
        }

        private static bool checkQuantity(string quantity, int shoeId)
        {
            if (quantity.All(char.IsDigit))
            {
                int q = Int32.Parse(quantity);
                int stock = ShoeController.checkStock(shoeId);
                if(q > 0 && q < stock)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool checkSameProduct(int userId, int shoeId)
        {
            CartModel cart = CartHandler.getSpecificProductUserCart(userId, shoeId);
            if (cart != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<CartModel> cartByUserId(int userId)
        {
            return CartHandler.getUserCart(userId);
        }

        public static bool deleteCartById(int cartId)
        {
            UserCart cart = CartHandler.findCartByID(cartId);
            if (cart != null)
            {
                CartRepository.deleteCart(cart);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}