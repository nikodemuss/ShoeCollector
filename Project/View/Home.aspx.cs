using Project.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();

            if (Session["Role"] != null && Session["Role"].ToString() == UserHandler.findUserRole("U001").UserRoleId.ToString())
            {
                //Txt_AddToCart.Visible = true;
                CartBtn.Visible = true;
                ChangePasswordBtn.Visible = true;
                AddToCartBtn.Visible = true;
                ProfileBtn.Visible = true;
                LogoutBtn.Visible = true;
            }
            else if (Session["Role"] != null && Session["Role"].ToString() == UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                ProfileBtn.Visible = true;
                ChangePasswordBtn.Visible = true;
                LogoutBtn.Visible = true;
                ViewMemberBtn.Visible = true;
                AddProductBtn.Visible = true;
                UpdateProductBtn.Visible = true;
                ViewTransactionsBtn.Visible = true;
                TransactionReportBtn.Visible = true;
            }
            else
            {
                RegisterBtn.Visible = true;
            }
        }

        public void loadData()
        {

            topDGV.DataSource = ShoeHandler.top5Product();
            topDGV.DataBind();

        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Home.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("/View/Login.aspx");
        }

        protected void ViewProductsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/ViewProduct.aspx");

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Register.aspx");

        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Profile.aspx");

        }

        protected void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/ChangePassowrd.aspx");

        }

        protected void AddToCartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Home.aspx");

        }

        protected void CartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Cart.aspx");

        }

        protected void ViewTransactionsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/ViewTransaction.aspx");

        }

        protected void AddProductBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/AddProduct.aspx");

        }

        protected void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/UpdateProduct.aspx");

        }

        protected void TransactionReportBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/TransactionReport.aspx");

        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Logout.aspx");

        }
    }
}