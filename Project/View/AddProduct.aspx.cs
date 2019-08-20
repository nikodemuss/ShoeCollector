using Project.Controller;
using Project.Factory;
using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                Response.Redirect("/View/Login.aspx");
            }
            loadData();
        }
        public void loadData()
        {
            shoeDGV.DataSource = ShoeRepository.getShoeData();
            shoeDGV.DataBind();
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(shoeImageUpload.PostedFile.FileName).ToLower() == ".jpg" || Path.GetExtension(shoeImageUpload.PostedFile.FileName).ToLower() == ".png")
            {
                string shoeImage = Path.GetFileName(shoeImageUpload.PostedFile.FileName);
                shoeImageUpload.PostedFile.SaveAs(Server.MapPath("~/Uploads/") + shoeImage);
                if (ShoeController.addProduct(shoeNameTxt.Text, shoePriceTxt.Text, shoeStockTxt.Text, shoeImage))
                {
                    Label_Error.Text = "Success";
                    loadData();
                }
                else
                {
                    Label_Error.Text = "Please Check the Data!";
                }
            }
            else
            {
                Label_Error.Text = "Please Check the Data!";
            }
        }
    }
}