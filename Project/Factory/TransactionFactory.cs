using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class TransactionFactory
    {
        public static Transaction createTransaction(string transactionStatus, DateTime transactionDate, int productId, int userId, int quantity, int subtotal)
        {
            return new Transaction()
            {
                TransactionStatus = transactionStatus,
                TransactionDate = transactionDate,
                ProductId = productId,
                UserId = userId,
                Quantity = quantity,
                Subtotal = subtotal
            };
        }
    }
}