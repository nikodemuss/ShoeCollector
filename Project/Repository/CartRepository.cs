using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class CartRepository
    {
        public static void insertCart(UserCart newCart)
        {
            DBSingleton.getDB().UserCart.Add(newCart); //lamda exprestion
            DBSingleton.getDB().SaveChanges();
        }
        //CRUD 
        //Read
        public static List<UserCart> getUserCart()
        {
            return DBSingleton.getDB().UserCart.ToList();
        }



        //Update
        public static void updateCart(int cartId, int userId, int shoeId, int quantity)
        {
            UserCart updateCart = DBSingleton.getDB().UserCart.Where(y => y.CartId == cartId).SingleOrDefault();
            updateCart.UserId = userId;
            updateCart.ShoeId = shoeId;
            updateCart.Quantity = quantity;
            DBSingleton.getDB().SaveChanges();
        }

        //Delete
        public static void deleteCart(UserCart delCart)
        {
            DBSingleton.getDB().UserCart.Remove(delCart);
            DBSingleton.getDB().SaveChanges();
        }
    }
}