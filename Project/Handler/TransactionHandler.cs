using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionModel> getTransaction()
        {
            var joinQuery = from trans in DBSingleton.getDB().Transaction
                            join user in DBSingleton.getDB().MsUser
                            on trans.UserId equals user.UserId
                            join shoe in DBSingleton.getDB().ShoeTable
                            on trans.ProductId equals shoe.ShoeId
                            select new TransactionModel
                            {
                                MemberName = user.UserName,
                                ProductName = shoe.ShoeName,
                                ProductPrice = shoe.ShoePrice,
                                Quantity = trans.Quantity,
                                Subtotal = trans.Quantity * shoe.ShoePrice,
                                TransactionDate = trans.TransactionDate,
                                TransactionStatus = trans.TransactionStatus,
                                TransactionId = trans.TransactionId
                            };
            List<TransactionModel> joinList = new List<TransactionModel>();
            foreach (var item in joinQuery)
            {
                joinList.Add(item);
            }
            return joinList;

        }

        public static List<TransactionModel> getTransactionForSpecificUser(int id)
        {
            var joinQuery = from trans in DBSingleton.getDB().Transaction
                            join user in DBSingleton.getDB().MsUser
                            on trans.UserId equals user.UserId
                            join shoe in DBSingleton.getDB().ShoeTable
                            on trans.ProductId equals shoe.ShoeId
                            where user.UserId == id
                            select new TransactionModel
                            {
                                MemberName = user.UserName,
                                ProductName = shoe.ShoeName,
                                ProductPrice = shoe.ShoePrice,
                                Quantity = trans.Quantity,
                                Subtotal = trans.Quantity * shoe.ShoePrice,
                                TransactionDate = trans.TransactionDate,
                                TransactionStatus = trans.TransactionStatus,
                                TransactionId = trans.TransactionId
                            };
            List<TransactionModel> joinList = new List<TransactionModel>();
            foreach (var item in joinQuery)
            {
                joinList.Add(item);
            }
            return joinList;

        }

        public static Transaction getSingleTransaction(int id)
        {
            List<Transaction> data = TransactionRepository.getTransaction();
            return data.Where(x => x.TransactionId == id).SingleOrDefault();
        }
    }
}