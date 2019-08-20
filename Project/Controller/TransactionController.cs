using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class TransactionController
    {
        public static bool updateToApproved(int id)
        {
            Transaction trans = TransactionHandler.getSingleTransaction(id);
            TransactionRepository.updateTransaction(trans.TransactionId, "Approved", trans.Quantity, trans.Subtotal);
            return true;
        }
    }
}