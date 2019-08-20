using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Model
{
    public class TransactionModel
    {
        public DateTime TransactionDate { set; get; }
        public string MemberName { set; get; }
        public string TransactionStatus { set; get; }
        public string ProductName { set; get; }
        public int Quantity { set; get; }
        public int ProductPrice { set; get; }
        public int Subtotal { set; get; }
        public int TransactionId { set; get; }

    }
}