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
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();

            if (Session["Role"] != null && Session["Role"].ToString() == UserHandler.findUserRole("U001").UserRoleId.ToString())
            {
                //Txt_AddToCart.Visible = true;
                Btn_AddToCart.Visible = true;
            }
            else if (Session["Role"] != null && Session["Role"].ToString() == UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                Btn_AddProduct.Visible = true;
                Btn_UpdateProduct.Visible = true;
                Btn_DeleteProduct.Visible = true;
            }
        }

        public void loadData()
        {
            shoeDGV.DataSource = ShoeRepository.getShoeData();
            shoeDGV.DataBind();
        }

        protected void Btn_AddToCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/AddToCart.aspx");
        }

        protected void Btn_AddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/AddProduct.aspx");
        }

        protected void Btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/UpdateProduct.aspx");
        }

        protected void Btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/DeleteProduct.aspx");
        }

        protected void Btn_Search_Click(object sender, EventArgs e)
        {
            string search = Txt_Search.Text;
            shoeSearch.DataSource = ShoeHandler.findShoeByName(search);
            shoeSearch.DataBind();
        }
    }
}