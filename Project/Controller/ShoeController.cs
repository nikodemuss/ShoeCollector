using Project.Factory;
using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ShoeController
    {
        public static bool addProduct(string shoeName, string price, string stock, string shoeImage)
        {
            if (shoeName != "" && checkPrice(price) && checkStock(stock))
            {
                int shoePrice = Int32.Parse(price);
                int shoeStock = Int32.Parse(stock);
                ShoeTable newShoe = ShoeFactory.createShoe(shoeName, shoePrice, shoeStock, shoeImage);
                ShoeRepository.insertShoe(newShoe);
                return true;
            }
            else
            {
                //Label_Error.Text = "Please Check the Data!";
                return false;
            }
        }

        public static bool updateProduct(int updateId, string shoeName, string price, string stock, string shoeImage)
        {
            if (checkProductName(shoeName) && checkPrice(price) && checkStock(stock))
            {
                int updatePrice = Int32.Parse(price);
                int updateStock = Int32.Parse(stock);
                ShoeRepository.updateShoe(updateId, shoeName, updatePrice, updateStock, shoeImage);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool checkPrice(string shoePriceTxt)
        {
            if (shoePriceTxt != "" && shoePriceTxt.All(char.IsDigit))
            {
                return true;
            }
            else
                return false;
        }

        private static bool checkStock(string shoeStockTxt)
        {
            if (shoeStockTxt != "" && shoeStockTxt.All(char.IsDigit) && Int32.Parse(shoeStockTxt) > 0)
                return true;
            else
                return false;
        }

        private static bool checkProductName(string name)
        {
            if (name.Length > 4)
                return true;
            return false;
        }

        public static int checkStock(int id)
        {
            ShoeTable shoe = ShoeHandler.findShoeByID(id);
            if (shoe != null)
            {
                return shoe.ShoeStock;
            }
            return -1;
        }

        public static bool updateStock(int stock, int id)
        {
            if (stock > 0)
            {
                ShoeTable shoe = ShoeHandler.findShoeByID(id);
                ShoeRepository.updateShoe(shoe.ShoeId, shoe.ShoeName, shoe.ShoePrice, stock, shoe.ShoeImage);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool updateStockAfterCheckout(int qty, int id)
        {
            if (qty > 0)
            {
                ShoeTable shoe = ShoeHandler.findShoeByID(id);
                int stockNow = shoe.ShoeStock - qty;
                updateStock(stockNow, id);
                return true;
            }
            return false;
        }
    }
}