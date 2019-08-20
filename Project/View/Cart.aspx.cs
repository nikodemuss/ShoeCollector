using Project.Controller;
using Project.Factory;
using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Role"] == null || Session["Role"].ToString() == UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                Response.Redirect("/View/ViewProduct.aspx");
            }
            loadData();
        }
        public void loadData()
        {
            int userID = Int32.Parse(Session["UserID"].ToString());
            List<CartModel> data = CartController.cartByUserId(userID);
            productCart.DataSource = data;
            productCart.DataBind();
            
            
            int total = 0;
            foreach (CartModel price in data)
            {
                total += price.SubTotal;
            }
            grandTotal.Text = total.ToString();
        }

        protected void delProductBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(deleteProductId.Text);
            CartController.deleteCartById(id);
        }

        protected void checkout_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(Session["UserID"].ToString());
            List<CartModel> data = CartController.cartByUserId(userID);

            foreach (CartModel datum in data)
            {
                Transaction trans = TransactionFactory.createTransaction("Pending", DateTime.Now, datum.ShoeId, datum.UserId, datum.Quantity, datum.SubTotal);
                TransactionRepository.insertTransaction(trans);
                ShoeController.updateStockAfterCheckout(datum.Quantity, datum.ShoeId);
                CartController.deleteCartById(datum.CartId);
            }
            Response.Redirect("/View/ViewTransaction.aspx");

        }
    }
}