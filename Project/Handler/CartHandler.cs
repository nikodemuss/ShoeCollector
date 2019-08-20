using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class CartHandler
    {
        public static UserCart findCartByID(int id)
        {
            List<UserCart> data = CartRepository.getUserCart();
            return data.Where(x => x.CartId == id).SingleOrDefault();
        }

        public static List<UserCart> findCartByUserID(int id)
        {
            List<UserCart> data = CartRepository.getUserCart();
            return data.Where(x => x.UserId == id).ToList();
        }

        public static CartModel getSpecificProductUserCart(int userId, int productId)
        {
            var joinQuery = from cart in DBSingleton.getDB().UserCart
                            join user in DBSingleton.getDB().MsUser
                            on cart.UserId equals user.UserId
                            join shoe in DBSingleton.getDB().ShoeTable
                            on cart.ShoeId equals shoe.ShoeId
                            where user.UserId == userId && shoe.ShoeId == productId
                            select new CartModel
                            {
                                CartId = cart.CartId,
                                ShoeId = shoe.ShoeId,
                                UserId = user.UserId,
                                Quantity = cart.Quantity,
                                ShoeName = shoe.ShoeName,
                                ShoeImage = shoe.ShoeImage,
                                ShoePrice = shoe.ShoePrice
                            };
            return joinQuery.SingleOrDefault();
        }

        public static List<CartModel> getUserCart(int userId)
        {
            var joinQuery = from cart in DBSingleton.getDB().UserCart
                            join user in DBSingleton.getDB().MsUser
                            on cart.UserId equals user.UserId
                            join shoe in DBSingleton.getDB().ShoeTable
                            on cart.ShoeId equals shoe.ShoeId
                            //where user.UserId == userId && shoe.ShoeId == productId
                            select new CartModel
                            {
                                CartId = cart.CartId,
                                ShoeId = shoe.ShoeId,
                                UserId = user.UserId,
                                Quantity = cart.Quantity,
                                ShoeName = shoe.ShoeName,
                                ShoeImage = shoe.ShoeImage,
                                ShoePrice = shoe.ShoePrice,
                                SubTotal = shoe.ShoePrice * cart.Quantity
                            };
            //System.Diagnostics.Debug.WriteLine("JoinQuery = " + joinQuery);

            foreach (var str in joinQuery)
            {
                System.Diagnostics.Debug.WriteLine(str);
            }

            List<CartModel> joinList = new List<CartModel>();
            foreach (var item in joinQuery)
            {
                joinList.Add(item);
            }
            return joinList;
        }
    }
}