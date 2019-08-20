using Project.Controller;
using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("/View/ViewProduct.aspx");
            }
            loadData();
        }

        public void loadData()
        {
            int userID = Int32.Parse(Session["UserID"].ToString());
            List<UserCart> cart = CartHandler.findCartByUserID(userID);
            cartDGV.DataSource = cart;
            cartDGV.DataBind();

            List<ShoeTable> shoeCart = new List<ShoeTable>();
            foreach (UserCart x in cart)
            {
                ShoeTable shoeTemp = ShoeHandler.findShoeByID(x.ShoeId);
                shoeCart.Add(shoeTemp);
            }

            productCart.DataSource = shoeCart;
            productCart.DataBind();


            shoeDGV.DataSource = ShoeRepository.getShoeData();
            shoeDGV.DataBind();
        }

        protected void addToCartBtn_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(Session["UserID"].ToString());
            CartController.addToCart(Txt_AddToCart.Text, userID, itemQuantityTextBox.Text);
            loadData();

        }
    }
}