using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ShoeHandler
    {
        public static ShoeTable findShoeByID(int id)
        {
            List<ShoeTable> data = ShoeRepository.getShoeData();
            return data.Where(x => x.ShoeId == id).SingleOrDefault();
        }

        public static List<ShoeTable> findShoeByName(string name)
        {
            List<ShoeTable> data = ShoeRepository.getShoeData();
            return data.Where(x => x.ShoeName == name).ToList();
        }

        public static void incrementTotalSales(int id)
        {
            List<ShoeTable> data = ShoeRepository.getShoeData();
            ShoeTable incrementShoe = data.Where(y => y.ShoeId == id).SingleOrDefault();
            incrementShoe.TotalSales += 1;
            DBSingleton.getDB().SaveChanges();
        }

        public static List<ShoeTable> top5Product()
        {
            List<ShoeTable> data = ShoeRepository.getShoeData();
            return data.OrderByDescending(x => x.TotalSales).Take(5).ToList();
        }

    }
}