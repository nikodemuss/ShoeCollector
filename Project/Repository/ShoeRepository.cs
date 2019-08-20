using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class ShoeRepository
    {
        public static void insertShoe(ShoeTable newShoe)
        {
            DBSingleton.getDB().ShoeTable.Add(newShoe); //lamda exprestion
            DBSingleton.getDB().SaveChanges();
        }
        //CRUD 
        //Read
        public static List<ShoeTable> getShoeData()
        {
            try
            {
                List<ShoeTable> data = DBSingleton.getDB().ShoeTable.ToList();
                return data;
            }
            catch
            {

                ShoeTable b = new ShoeTable()
                {
                    ShoeId = 0,
                    ShoeImage = "Error.jpg",
                    ShoeName = "Error",
                    ShoePrice = 0,
                    ShoeStock = 0,
                    TotalSales = 0
                };
                List<ShoeTable> errorData = new List<ShoeTable>();
                errorData.Add(b);
                return errorData;
            }
            
        }



        //Update
        public static void updateShoe(int id, string updateName, int updatePrice, int updateStock, string updateImage)
        {
            ShoeTable updateShoe = DBSingleton.getDB().ShoeTable.Where(y => y.ShoeId == id).SingleOrDefault();
            updateShoe.ShoeName = updateName;
            updateShoe.ShoeStock = updateStock;
            updateShoe.ShoePrice = updatePrice;
            updateShoe.ShoeImage = updateImage;
            DBSingleton.getDB().SaveChanges();
        }

        //Delete
        public static void deleteShoe(ShoeTable delShoe)
        {
            DBSingleton.getDB().ShoeTable.Remove(delShoe);
            DBSingleton.getDB().SaveChanges();
        }
    }
}