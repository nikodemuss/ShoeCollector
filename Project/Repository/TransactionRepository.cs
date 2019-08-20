using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class TransactionRepository
    {
        public static void insertTransaction(Transaction newTransaction)
        {
            DBSingleton.getDB().Transaction.Add(newTransaction); //lamda exprestion
            DBSingleton.getDB().SaveChanges();
        }
        //CRUD 
        //Read
        public static List<Transaction> getTransaction()
        {
            return DBSingleton.getDB().Transaction.ToList();
        }



        //Update
        public static void updateTransaction(int transactionId, string transactionStatus, int quantity, int subtotal)
        {
            Transaction updateCart = DBSingleton.getDB().Transaction.Where(y => y.TransactionId == transactionId).SingleOrDefault();
            updateCart.TransactionId = transactionId;
            updateCart.TransactionStatus = transactionStatus;
            updateCart.Quantity = quantity;
            updateCart.Subtotal = subtotal;
            DBSingleton.getDB().SaveChanges();
        }

        //Delete
        public static void deleteTransaction(Transaction delTransaction)
        {
            DBSingleton.getDB().Transaction.Remove(delTransaction);
            DBSingleton.getDB().SaveChanges();
        }
    }
}