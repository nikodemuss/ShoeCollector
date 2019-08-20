using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Model
{
    public class CartModel
    {
        public int CartId { set; get; }
        public int UserId { set; get; }

        public int ShoeId { set; get; }

        public string ShoeName { set; get; }
        
        public string ShoeImage { set; get; }

        public int ShoePrice { set; get; }

        public int SubTotal { set; get; }


        public int Quantity { set; get; }
    }
}