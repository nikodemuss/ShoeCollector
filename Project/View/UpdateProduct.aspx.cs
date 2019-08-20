using Project.Controller;
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
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                Response.Redirect("/View/Home.aspx");
            }
            loadData();
        }
        
        public void loadData()
        {
            shoeDGV.DataSource = ShoeRepository.getShoeData();
            shoeDGV.DataBind();
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            if ((Path.GetExtension(updateShoeImage.PostedFile.FileName).ToLower() == ".jpg" || Path.GetExtension(updateShoeImage.PostedFile.FileName).ToLower() == ".png"))
            {
                int updateId = Int32.Parse(updateShoeID.Text);
                string updateName = updateShoeName.Text;
                string updateImage = Path.GetFileName(updateShoeImage.PostedFile.FileName);

                updateShoeImage.PostedFile.SaveAs(Server.MapPath("~/Uploads/") + updateImage);
                if(ShoeController.updateProduct(updateId, updateName, updateShoePrice.Text, updateShoeStock.Text, updateImage))
                {
                    Label_Error.Text = "Success!";
                    loadData();
                }
                else
                {
                    Label_Error.Text = "Please Check the Data!";
                }
            }
        }
    }
}