using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project
{
    public class DBSingleton
    {
        private static ShoeDBEntities myDB;

        public static ShoeDBEntities getDB()
        {
            if (myDB == null) return myDB = new ShoeDBEntities();
            else return myDB;
        }
    }
}